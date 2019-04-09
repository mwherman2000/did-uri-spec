/* -----------------------------------------------------------------------------
 * ParserContext.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ParserContext
{
  public readonly String text;
  public int index;

  private Stack<int> startStack = new Stack<int>();
  private Stack<String> callStack = new Stack<String>();
  private Stack<String> errorStack = new Stack<String>();
  private int level = 0;
  private int errorIndex = 0;

  private readonly bool traceOn;

  public ParserContext(String text, bool traceOn)
  {
    this.text = text;
    this.traceOn = traceOn;
    index = 0;
  }

  public void Push(String rulename)
  {
    Push(rulename, "");
  }

  public void Push(String rulename, String trace)
  {
    callStack.Push(rulename);
    startStack.Push(index);

    if (traceOn)
    {
      String sample = text.Substring(index, index + 10 > text.Length ? text.Length - index : 10);

      Regex regex = new Regex("[\\x00-\\x1F]");
      sample = regex.Replace(sample, " ");

      System.Console.WriteLine("-> " + ++level + ": " + rulename + "(" + (trace != null ? trace : "") + ")");
      System.Console.WriteLine(index + ": " + sample);
    }
  }

  public void Pop(String function, bool result)
  {
    int start = startStack.Pop();
    callStack.Pop();

    if (traceOn)
    {
      System.Console.WriteLine(
        "<- " + level-- + 
        ": " + function + 
        "(" + (result ? "true" : "false") + 
        ",s=" + start + 
        ",l=" + (index - start) + 
        ",e=" + errorIndex + ")");
    }

    if (!result)
    {
      if (index > errorIndex)
      {
        errorIndex = index;
        errorStack = new Stack<String>(callStack);
      }
      else if (index == errorIndex && errorStack.Count == 0)
      {
        errorStack = new Stack<String>(callStack);
      }
    }
    else
    {
      if (index > errorIndex) errorIndex = 0;
    }
  }

  public Stack<String> GetErrorStack()
  {
    return errorStack;
  }

  public int GetErrorIndex()
  {
    return errorIndex;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
