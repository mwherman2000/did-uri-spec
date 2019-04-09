/* -----------------------------------------------------------------------------
 * Visitor.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 10:53:02 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;

public interface Visitor
{
  Object Visit(Rule_Clock rule);
  Object Visit(Rule_Hours rule);
  Object Visit(Rule_Minutes rule);
  Object Visit(Rule_Seconds rule);
  Object Visit(Rule_Separator rule);

  Object Visit(Terminal_StringValue value);
  Object Visit(Terminal_NumericValue value);
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
