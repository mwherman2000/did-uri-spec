/* -----------------------------------------------------------------------------
 * Terminal_NumericValue.cs
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

public class Terminal_NumericValue:Rule
{
  private Terminal_NumericValue(String spelling, List<Rule> rules) :
  base(spelling, rules)
  {
  }

  public static Terminal_NumericValue Parse(
    ParserContext context, 
    String spelling, 
    String regex, 
    int length)
  {
    context.Push("NumericValue", spelling + "," + regex);

    bool parsed = true;

    Terminal_NumericValue numericValue = null;
    try
    {
      String value = context.text.Substring(context.index, length);

      if ((parsed = Regex.IsMatch(value, regex)))
      {
        context.index += length;
        numericValue = new Terminal_NumericValue(value, null);
      }
    }
    catch (ArgumentOutOfRangeException) {parsed = false;}

    context.Pop("NumericValue", parsed);

    return numericValue;
  }

  public override Object Accept(Visitor visitor)
  {
    return visitor.Visit(this);
  }
}
/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
