/* -----------------------------------------------------------------------------
 * Parser.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 11:06:12 PDT 2019
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
      arguments["Rule"] = "did";

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
    if (rulename.ToLower().Equals("did".ToLower())) rule = Rule_did.Parse(context);
    else if (rulename.ToLower().Equals("did-method".ToLower())) rule = Rule_did_method.Parse(context);
    else if (rulename.ToLower().Equals("did-root".ToLower())) rule = Rule_did_root.Parse(context);
    else if (rulename.ToLower().Equals("method".ToLower())) rule = Rule_method.Parse(context);
    else if (rulename.ToLower().Equals("methodchar".ToLower())) rule = Rule_methodchar.Parse(context);
    else if (rulename.ToLower().Equals("method-specific-idstring".ToLower())) rule = Rule_method_specific_idstring.Parse(context);
    else if (rulename.ToLower().Equals("idstring".ToLower())) rule = Rule_idstring.Parse(context);
    else if (rulename.ToLower().Equals("idchar".ToLower())) rule = Rule_idchar.Parse(context);
    else if (rulename.ToLower().Equals("did-uri".ToLower())) rule = Rule_did_uri.Parse(context);
    else if (rulename.ToLower().Equals("did-optional-transform".ToLower())) rule = Rule_did_optional_transform.Parse(context);
    else if (rulename.ToLower().Equals("did-method-transform".ToLower())) rule = Rule_did_method_transform.Parse(context);
    else if (rulename.ToLower().Equals("did-root-transform".ToLower())) rule = Rule_did_root_transform.Parse(context);
    else if (rulename.ToLower().Equals("transform".ToLower())) rule = Rule_transform.Parse(context);
    else if (rulename.ToLower().Equals("transformer".ToLower())) rule = Rule_transformer.Parse(context);
    else if (rulename.ToLower().Equals("transformer-namedvalue".ToLower())) rule = Rule_transformer_namedvalue.Parse(context);
    else if (rulename.ToLower().Equals("transformer-option".ToLower())) rule = Rule_transformer_option.Parse(context);
    else if (rulename.ToLower().Equals("transformer-value".ToLower())) rule = Rule_transformer_value.Parse(context);
    else if (rulename.ToLower().Equals("transformer-char".ToLower())) rule = Rule_transformer_char.Parse(context);
    else if (rulename.ToLower().Equals("TRANSFORM".ToLower())) rule = Rule_TRANSFORM.Parse(context);
    else if (rulename.ToLower().Equals("generic-option".ToLower())) rule = Rule_generic_option.Parse(context);
    else if (rulename.ToLower().Equals("transformer-options".ToLower())) rule = Rule_transformer_options.Parse(context);
    else if (rulename.ToLower().Equals("URI".ToLower())) rule = Rule_URI.Parse(context);
    else if (rulename.ToLower().Equals("hier-part".ToLower())) rule = Rule_hier_part.Parse(context);
    else if (rulename.ToLower().Equals("scheme".ToLower())) rule = Rule_scheme.Parse(context);
    else if (rulename.ToLower().Equals("authority".ToLower())) rule = Rule_authority.Parse(context);
    else if (rulename.ToLower().Equals("userinfo".ToLower())) rule = Rule_userinfo.Parse(context);
    else if (rulename.ToLower().Equals("host".ToLower())) rule = Rule_host.Parse(context);
    else if (rulename.ToLower().Equals("port".ToLower())) rule = Rule_port.Parse(context);
    else if (rulename.ToLower().Equals("IP-literal".ToLower())) rule = Rule_IP_literal.Parse(context);
    else if (rulename.ToLower().Equals("IPvFuture".ToLower())) rule = Rule_IPvFuture.Parse(context);
    else if (rulename.ToLower().Equals("IPv6address".ToLower())) rule = Rule_IPv6address.Parse(context);
    else if (rulename.ToLower().Equals("h16".ToLower())) rule = Rule_h16.Parse(context);
    else if (rulename.ToLower().Equals("ls32".ToLower())) rule = Rule_ls32.Parse(context);
    else if (rulename.ToLower().Equals("IPv4address".ToLower())) rule = Rule_IPv4address.Parse(context);
    else if (rulename.ToLower().Equals("dec-octet".ToLower())) rule = Rule_dec_octet.Parse(context);
    else if (rulename.ToLower().Equals("reg-name".ToLower())) rule = Rule_reg_name.Parse(context);
    else if (rulename.ToLower().Equals("path-abempty".ToLower())) rule = Rule_path_abempty.Parse(context);
    else if (rulename.ToLower().Equals("path-absolute".ToLower())) rule = Rule_path_absolute.Parse(context);
    else if (rulename.ToLower().Equals("path-rootless".ToLower())) rule = Rule_path_rootless.Parse(context);
    else if (rulename.ToLower().Equals("segment".ToLower())) rule = Rule_segment.Parse(context);
    else if (rulename.ToLower().Equals("segment-nz".ToLower())) rule = Rule_segment_nz.Parse(context);
    else if (rulename.ToLower().Equals("pchar".ToLower())) rule = Rule_pchar.Parse(context);
    else if (rulename.ToLower().Equals("query".ToLower())) rule = Rule_query.Parse(context);
    else if (rulename.ToLower().Equals("fragment".ToLower())) rule = Rule_fragment.Parse(context);
    else if (rulename.ToLower().Equals("pct-encoded".ToLower())) rule = Rule_pct_encoded.Parse(context);
    else if (rulename.ToLower().Equals("unreserved".ToLower())) rule = Rule_unreserved.Parse(context);
    else if (rulename.ToLower().Equals("sub-delims".ToLower())) rule = Rule_sub_delims.Parse(context);
    else if (rulename.ToLower().Equals("other-delims".ToLower())) rule = Rule_other_delims.Parse(context);
    else if (rulename.ToLower().Equals("pchar-no-SQUOTE".ToLower())) rule = Rule_pchar_no_SQUOTE.Parse(context);
    else if (rulename.ToLower().Equals("pct-encoded-no-SQUOTE".ToLower())) rule = Rule_pct_encoded_no_SQUOTE.Parse(context);
    else if (rulename.ToLower().Equals("qchar-no-AMP".ToLower())) rule = Rule_qchar_no_AMP.Parse(context);
    else if (rulename.ToLower().Equals("qchar-no-AMP-EQ".ToLower())) rule = Rule_qchar_no_AMP_EQ.Parse(context);
    else if (rulename.ToLower().Equals("qchar-no-AMP-EQ-AT-DOLLAR".ToLower())) rule = Rule_qchar_no_AMP_EQ_AT_DOLLAR.Parse(context);
    else if (rulename.ToLower().Equals("ALPHA".ToLower())) rule = Rule_ALPHA.Parse(context);
    else if (rulename.ToLower().Equals("DIGIT".ToLower())) rule = Rule_DIGIT.Parse(context);
    else if (rulename.ToLower().Equals("HEXDIG".ToLower())) rule = Rule_HEXDIG.Parse(context);
    else if (rulename.ToLower().Equals("A-to-F".ToLower())) rule = Rule_A_to_F.Parse(context);
    else if (rulename.ToLower().Equals("DQUOTE".ToLower())) rule = Rule_DQUOTE.Parse(context);
    else if (rulename.ToLower().Equals("SP".ToLower())) rule = Rule_SP.Parse(context);
    else if (rulename.ToLower().Equals("HTAB".ToLower())) rule = Rule_HTAB.Parse(context);
    else if (rulename.ToLower().Equals("VCHAR".ToLower())) rule = Rule_VCHAR.Parse(context);
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
