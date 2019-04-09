/* -----------------------------------------------------------------------------
 * Parser.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class Parser
{
  private Parser() {}

  static public void Main(String[] args)
  {
    Dictionary<String, String> arguments = new Dictionary<String, String>();
    String error = "";
    bool ok = args.Length > 0;

    if (ok)
    {
      arguments["Trace"] = "Off";
      arguments["Rule"] = "Clock";

      for (int i = 0; i < args.Length; i++)
      {
        if (args[i].Equals("-trace"))
          arguments["Trace"] = "On";
        else if (args[i].Equals("-visitor"))
          arguments["Visitor"] = args[++i];
        else if (args[i].Equals("-file"))
          arguments["File"] = args[++i];
        else if (args[i].Equals("-string"))
          arguments["String"] = args[++i];
        else if (args[i].Equals("-rule"))
          arguments["Rule"] = args[++i];
        else
        {
          error = "unknown argument: " + args[i];
          ok = false;
        }
      }
    }

    if (ok)
    {
      if (!arguments.ContainsKey("File") &&
          !arguments.ContainsKey("String"))
      {
        error = "insufficient arguments: -file or -string required";
        ok = false;
      }
    }

    if (!ok)
    {
      System.Console.WriteLine("error: " + error);
      System.Console.WriteLine("usage: Parser [-rule rulename] [-trace] <-file file | -string string> [-visitor visitor]");
    }
    else
    {
      try
      {
        Rule rule = null;

        if (arguments.ContainsKey("File"))
        {
          rule = 
            Parse(
              arguments["Rule"], 
              new FileStream(arguments["File"], FileMode.Open), 
              arguments["Trace"].Equals("On"));
        }
        else if (arguments.ContainsKey("String"))
        {
          rule = 
            Parse(
              arguments["Rule"], 
              arguments["String"], 
              arguments["Trace"].Equals("On"));
        }

        if (arguments.ContainsKey("Visitor"))
        {
          Type type = Type.GetType(arguments["Visitor"]);

          if (type == null)
          {
            System.Console.WriteLine(
              "visitor error: class not found - " + 
              arguments["Visitor"]);
          }
          else
          {
            Visitor visitor = (Visitor)System.Activator.CreateInstance(type);

            rule.Accept(visitor);
          }
        }
      }
      catch (ArgumentException e)
      {
        System.Console.WriteLine("argument error: " + e.Message);
      }
      catch (IOException e)
      {
        System.Console.WriteLine("io error: " + e.Message);
      }
      catch (ParserException e)
      {
        System.Console.WriteLine("parser error: " + e.Message);
      }
      catch (Exception e)
      {
        System.Console.WriteLine("error: " + e.Message);
      }
    }
  }

  static public Rule Parse(String rulename, String text)
  {
    return Parse(rulename, text, false);
  }

  static public Rule Parse(String rulename, StreamReader input)
  {
    return Parse(rulename, input, false);
  }

  static public Rule Parse(String rulename, FileStream file)
  {
    return Parse(rulename, file, false);
  }

  static private Rule Parse(String rulename, String text, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (text == null)
      throw new ArgumentException("null string");

    ParserContext context = new ParserContext(text, trace);

    Rule rule = null;
    if (rulename.ToLower().Equals("Clock".ToLower())) rule = Rule_Clock.Parse(context);
    else if (rulename.ToLower().Equals("Hours".ToLower())) rule = Rule_Hours.Parse(context);
    else if (rulename.ToLower().Equals("Minutes".ToLower())) rule = Rule_Minutes.Parse(context);
    else if (rulename.ToLower().Equals("Seconds".ToLower())) rule = Rule_Seconds.Parse(context);
    else if (rulename.ToLower().Equals("Separator".ToLower())) rule = Rule_Separator.Parse(context);
    else throw new ArgumentException("unknown rule");

    if (rule == null)
    {
      throw new ParserException(
        "rule \"" + (String)context.GetErrorStack().Peek() + "\" failed",
        context.text,
        context.GetErrorIndex(),
        context.GetErrorStack());
    }

    if (context.text.Length > context.index)
    {
      ParserException primaryError = 
        new ParserException(
          "extra data found",
          context.text,
          context.index,
          new Stack<String>());

      if (context.GetErrorIndex() > context.index)
      {
        ParserException secondaryError = 
          new ParserException(
            "rule \"" + (String)context.GetErrorStack().Peek() + "\" failed",
            context.text,
            context.GetErrorIndex(),
            context.GetErrorStack());

        primaryError.SetCause(secondaryError);
      }

      throw primaryError;
    }

    return rule;
  }

  static private Rule Parse(String rulename, StreamReader input, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (input == null)
      throw new ArgumentNullException("null input stream");

    int ch = 0;
    StringBuilder output = new StringBuilder();
    while ((ch = input.Read()) != -1)
      output.Append((char)ch);

    return Parse(rulename, output.ToString(), trace);
  }

  static private Rule Parse(String rulename, FileStream file, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (file == null)
      throw new ArgumentNullException("null file");

    StreamReader input = new StreamReader(file);
    int ch = 0;
    StringBuilder output = new StringBuilder();
    while ((ch = input.Read()) != -1)
      output.Append((char)ch);

    input.Close();

    return Parse(rulename, output.ToString(), trace);
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
