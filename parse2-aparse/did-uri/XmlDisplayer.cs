/* -----------------------------------------------------------------------------
 * XmlDisplayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 11:06:12 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class XmlDisplayer:Visitor
{
  private bool terminal = true;

  public Object Visit(Rule_did rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_method rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-method>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-method>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_root rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-root>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-root>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_method rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<method>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</method>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_methodchar rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<methodchar>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</methodchar>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_method_specific_idstring rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<method-specific-idstring>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</method-specific-idstring>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_idstring rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<idstring>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</idstring>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_idchar rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<idchar>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</idchar>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_uri rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-uri>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-uri>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_optional_transform rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-optional-transform>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-optional-transform>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_method_transform rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-method-transform>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-method-transform>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_did_root_transform rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<did-root-transform>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</did-root-transform>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transform rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transform>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transform>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer_namedvalue rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer-namedvalue>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer-namedvalue>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer_option rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer-option>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer-option>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer_value rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer-value>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer-value>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer_char rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer-char>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer-char>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_TRANSFORM rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<TRANSFORM>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</TRANSFORM>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_generic_option rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<generic-option>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</generic-option>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_transformer_options rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<transformer-options>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</transformer-options>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_URI rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<URI>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</URI>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_hier_part rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<hier-part>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</hier-part>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_scheme rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<scheme>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</scheme>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_authority rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<authority>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</authority>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_userinfo rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<userinfo>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</userinfo>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_host rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<host>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</host>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_port rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<port>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</port>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_IP_literal rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<IP-literal>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</IP-literal>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_IPvFuture rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<IPvFuture>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</IPvFuture>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_IPv6address rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<IPv6address>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</IPv6address>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_h16 rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<h16>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</h16>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_ls32 rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<ls32>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</ls32>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_IPv4address rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<IPv4address>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</IPv4address>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_dec_octet rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<dec-octet>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</dec-octet>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_reg_name rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<reg-name>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</reg-name>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_path_abempty rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<path-abempty>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</path-abempty>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_path_absolute rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<path-absolute>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</path-absolute>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_path_rootless rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<path-rootless>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</path-rootless>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_segment rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<segment>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</segment>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_segment_nz rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<segment-nz>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</segment-nz>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_pchar rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<pchar>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</pchar>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_query rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<query>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</query>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_fragment rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<fragment>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</fragment>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_pct_encoded rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<pct-encoded>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</pct-encoded>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_unreserved rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<unreserved>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</unreserved>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_sub_delims rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<sub-delims>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</sub-delims>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_other_delims rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<other-delims>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</other-delims>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_pchar_no_SQUOTE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<pchar-no-SQUOTE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</pchar-no-SQUOTE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_pct_encoded_no_SQUOTE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<pct-encoded-no-SQUOTE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</pct-encoded-no-SQUOTE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_qchar_no_AMP rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<qchar-no-AMP>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</qchar-no-AMP>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_qchar_no_AMP_EQ rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<qchar-no-AMP-EQ>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</qchar-no-AMP-EQ>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_qchar_no_AMP_EQ_AT_DOLLAR rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<qchar-no-AMP-EQ-AT-DOLLAR>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</qchar-no-AMP-EQ-AT-DOLLAR>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_ALPHA rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<ALPHA>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</ALPHA>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_DIGIT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<DIGIT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</DIGIT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_HEXDIG rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<HEXDIG>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</HEXDIG>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_A_to_F rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<A-to-F>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</A-to-F>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_DQUOTE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<DQUOTE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</DQUOTE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_SP rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<SP>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</SP>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_HTAB rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<HTAB>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</HTAB>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_VCHAR rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<VCHAR>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</VCHAR>");
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
