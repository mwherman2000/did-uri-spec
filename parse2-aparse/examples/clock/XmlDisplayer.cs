/* -----------------------------------------------------------------------------
 * XmlDisplayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class XmlDisplayer:Visitor
{
  private bool terminal = true;

  public Object Visit(Rule_Clock rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Clock>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Clock>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_Hours rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Hours>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Hours>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_Minutes rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Minutes>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Minutes>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_Seconds rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Seconds>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Seconds>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_Separator rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Separator>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Separator>");
    terminal = false;
    return null;
  }

  public Object Visit(Terminal_StringValue value)
  {
    Console.Write(value.spelling);
    terminal = true;
    return null;
  }

  public Object Visit(Terminal_NumericValue value)
  {
    Console.Write(value.spelling);
    terminal = true;
    return null;
  }

  private Object VisitRules(List<Rule> rules)
  {
    foreach (Rule rule in rules)
      rule.Accept(this);
    return null;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
