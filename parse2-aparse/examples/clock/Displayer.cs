/* -----------------------------------------------------------------------------
 * Displayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class Displayer:Visitor
{

  public Object Visit(Rule_Clock rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_Hours rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_Minutes rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_Seconds rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_Separator rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Terminal_StringValue value)
  {
    Console.Write(value.spelling);
    return null;
  }

  public Object Visit(Terminal_NumericValue value)
  {
    Console.Write(value.spelling);
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
