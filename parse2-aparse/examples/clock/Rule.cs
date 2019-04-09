/* -----------------------------------------------------------------------------
 * Rule.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public abstract class Rule
{
  public readonly String spelling;
  public readonly List<Rule> rules;

  protected Rule(String spelling, List<Rule> rules)
  {
    this.spelling = spelling;
    this.rules = rules;
  }

  public override String ToString()
  {
    return spelling;
  }

  public override Boolean Equals(Object rule)
  {
    return rule is Rule && spelling.Equals(((Rule)rule).spelling);
  }

  public override int GetHashCode()
  {
    return spelling.GetHashCode();
  }

  public int CompareTo(Rule rule)
  {
    return spelling.CompareTo(rule.spelling);
  }

  public abstract Object Accept(Visitor visitor);
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
