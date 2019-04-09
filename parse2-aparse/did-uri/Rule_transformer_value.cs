/* -----------------------------------------------------------------------------
 * Rule_transformer_value.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 11:06:12 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

sealed public class Rule_transformer_value:Rule
{
  private Rule_transformer_value(String spelling, List<Rule> rules) :
  base(spelling, rules)
  {
  }

  public override Object Accept(Visitor visitor)
  {
    return visitor.Visit(this);
  }

  public static Rule_transformer_value Parse(ParserContext context)
  {
    context.Push("transformer-value");

    Rule rule;
    bool parsed = true;
    ParserAlternative b;
    int s0 = context.index;
    ParserAlternative a0 = new ParserAlternative(s0);

    List<ParserAlternative> as1 = new List<ParserAlternative>();
    parsed = false;
    {
      int s1 = context.index;
      ParserAlternative a1 = new ParserAlternative(s1);
      parsed = true;
      if (parsed)
      {
        bool f1 = true;
        int c1 = 0;
        while (f1)
        {
          rule = Rule_transformer_char.Parse(context);
          if ((f1 = rule != null))
          {
            a1.Add(rule, context.index);
            c1++;
          }
        }
        parsed = true;
      }
      if (parsed)
      {
        as1.Add(a1);
      }
      context.index = s1;
    }

    b = ParserAlternative.GetBest(as1);

    parsed = b != null;

    if (parsed)
    {
      a0.Add(b.rules, b.end);
      context.index = b.end;
    }

    rule = null;
    if (parsed)
    {
        rule = new Rule_transformer_value(context.text.Substring(a0.start, a0.end - a0.start), a0.rules);
    }
    else
    {
        context.index = s0;
    }

    context.Pop("transformer-value", parsed);

    return (Rule_transformer_value)rule;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
