/* -----------------------------------------------------------------------------
 * Visitor.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 11:06:12 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;

public interface Visitor
{
  Object Visit(Rule_did rule);
  Object Visit(Rule_did_method rule);
  Object Visit(Rule_did_root rule);
  Object Visit(Rule_method rule);
  Object Visit(Rule_methodchar rule);
  Object Visit(Rule_method_specific_idstring rule);
  Object Visit(Rule_idstring rule);
  Object Visit(Rule_idchar rule);
  Object Visit(Rule_did_uri rule);
  Object Visit(Rule_did_optional_transform rule);
  Object Visit(Rule_did_method_transform rule);
  Object Visit(Rule_did_root_transform rule);
  Object Visit(Rule_transform rule);
  Object Visit(Rule_transformer rule);
  Object Visit(Rule_transformer_namedvalue rule);
  Object Visit(Rule_transformer_option rule);
  Object Visit(Rule_transformer_value rule);
  Object Visit(Rule_transformer_char rule);
  Object Visit(Rule_TRANSFORM rule);
  Object Visit(Rule_generic_option rule);
  Object Visit(Rule_transformer_options rule);
  Object Visit(Rule_URI rule);
  Object Visit(Rule_hier_part rule);
  Object Visit(Rule_scheme rule);
  Object Visit(Rule_authority rule);
  Object Visit(Rule_userinfo rule);
  Object Visit(Rule_host rule);
  Object Visit(Rule_port rule);
  Object Visit(Rule_IP_literal rule);
  Object Visit(Rule_IPvFuture rule);
  Object Visit(Rule_IPv6address rule);
  Object Visit(Rule_h16 rule);
  Object Visit(Rule_ls32 rule);
  Object Visit(Rule_IPv4address rule);
  Object Visit(Rule_dec_octet rule);
  Object Visit(Rule_reg_name rule);
  Object Visit(Rule_path_abempty rule);
  Object Visit(Rule_path_absolute rule);
  Object Visit(Rule_path_rootless rule);
  Object Visit(Rule_segment rule);
  Object Visit(Rule_segment_nz rule);
  Object Visit(Rule_pchar rule);
  Object Visit(Rule_query rule);
  Object Visit(Rule_fragment rule);
  Object Visit(Rule_pct_encoded rule);
  Object Visit(Rule_unreserved rule);
  Object Visit(Rule_sub_delims rule);
  Object Visit(Rule_other_delims rule);
  Object Visit(Rule_pchar_no_SQUOTE rule);
  Object Visit(Rule_pct_encoded_no_SQUOTE rule);
  Object Visit(Rule_qchar_no_AMP rule);
  Object Visit(Rule_qchar_no_AMP_EQ rule);
  Object Visit(Rule_qchar_no_AMP_EQ_AT_DOLLAR rule);
  Object Visit(Rule_ALPHA rule);
  Object Visit(Rule_DIGIT rule);
  Object Visit(Rule_HEXDIG rule);
  Object Visit(Rule_A_to_F rule);
  Object Visit(Rule_DQUOTE rule);
  Object Visit(Rule_SP rule);
  Object Visit(Rule_HTAB rule);
  Object Visit(Rule_VCHAR rule);

  Object Visit(Terminal_StringValue value);
  Object Visit(Terminal_NumericValue value);
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
