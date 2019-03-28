# Hyperonomy Universal Decentralized Identifier URI Specification (`did-uri-spec`)

_Draft document for discussion purposes_

- Michael Herman (Toronto/Calgary/Seattle)
- Hyperonomy Business Blockchain Project / Parallelspace Corporation
- March 2019

Update cycle: As required - sometimes several times in a single day.

## Table of Contents

<!-- TOC -->

- [Hyperonomy Universal Decentralized Identifier URI Specification (`did-uri-spec`)](#decentralized-identifier-uri-did-uri-specification-did-uri-spec)
    - [Purpose, Goals, Drivers, and Approach](#purpose-status-goals-drivers-and-approach)
        - [Purpose](#purpose)
        - [Status of this Specification](#status-of-this-specification)
        - [Goals](#goals)
        - [Drivers](#drivers)
        - [Approach](#approach)
        - [Guiding Principles](#guiding-principles)
        - [Higher-Level Use Case Documents](#higher-level-use-case-documents)
    - [Lower-level DID User Scenarios](#lower-level-did-user-scenarios)
    - [Impact on DID Document Grammar](#impact-on-did-document-grammar)
    - [`did-uri` Grammar Validation Tool (Web)](#did-uri-grammar-validation-tool-web)
    - [Appendix A - `did-uri` Use Case Category H. DID URI Service Endpoint Transformer Use Case Discussion](#appendix-a---did-uri-user-case-category-h-did-uri-service-endpoint-transformation-use-cases-using--transformer-pipe-option-and-serviceid-transform-option)
    - [Appendix B - DID Document Examples](#appendix-b---did-document-examples)
    - [Appendix C - `did-uri` Grammar - Previous Versions](#appendix-c---did-uri-grammar---previous-versions)
    - [Appendix D - Other References](#appendix-d---other-references)

<!-- /TOC -->

## Purpose, Status, Goals, Drivers, and Approach

### Purpose

The purpose of this specification is to document the development of as well as the final version of the `did-uri` grammar for the Hyperonomy Universal Decentralized Identifier URI Specification (the [`did-uri-spec`](https://github.com/mwherman2000/did-uri-spec)) - that is, a specification focused specifically on the `did-uri` grammar expressed in the ABNF notation for creating executable `did-uri` compliant software parsers for use in a variety of apps and services where the `did-uri` grammar is used; for example:

- [W3C Decentralized Identifier specification](https://github.com/w3c-ccg/did-spec)
- DID Resolvers and [DID Resolution](https://github.com/w3c-ccg/did-resolution)
- Agent-to-Agent (A2) Communications services in the Hyperledger Indy Agent framework - for example,
   - the [Indy draft feature-discovery 1.0 HIPE](https://github.com/dhh1128/indy-hipe/blob/9c7722d208cfe0a336cb67a626cbbb192ae73f8c/text/feature-discovery/README.md), and
   - the [Indy draft attachments HIPE](https://github.com/hyperledger/indy-hipe/blob/bd48bae3712e659c34d88c6dea839ccf5a0f0701/text/attachments/README.md#hipe-00-attachments).

## Status of this Specification

- The status of this specification is that it is a (work-in-progress) _community member contribution_.  

![work-in-progress community member contribution](images/protocol-lifecycle.png)

- The intention is for this specification to be merged into the W3C Decentralized Identifiers specification directly, by reference, or as an appendix.

NOTE: This document is a specification specifically for Universal Decentralized Identifier URIs ...described by the `did-uri` grammar using the ABNF notation. For a better understanding of these terms, read [Giving Grammars Written with ABNF Notation the Respect They Deserve](https://hyperonomy.com/2019/03/11/giving-grammars-written-with-abnf-notation-the-respect-they-deserve/).

This document supercedes and obsoletes DID-Resolution issue [`did-uri` Use Cases: `did-uri` Syntax Examples (and corresponding HTTP Binding Examples)](https://github.com/w3c-ccg/did-resolution/issues/32) - which is now closed.

### Goals

The primary goal of this specification is to document the development of the `did-uri-spec` version of the `did-uri` grammar as well as to publish the final version of the grammar.

### Non-goals

It is not a goal of this discussion force any particular project or specifications effort to adopt this specification but it is hoped that this speciciation significantly influences the current state and all future states of the `did-uri` grammar discussions.

### Drivers

During the Feb. 21, 2019 DID Resolution community call, there was a early/initial discussion about using an HTTP binding pattern such as:

>`http://uniresolver.io/resolve/did:xyz:1234`

>`http://uniresolver.io/dereference/did:xyz:1234#key1`

It was surprising to see the above pattern being proposed because the resolve and dereference operations are redundant.

I assume that the purpose of the current "DID ABNF" syntax discussions is to encapsulate these types of operations into a `did-uri` grammar specification. Based on this assumption, the following `did-uri` patterns (and corresponding HTTP bindings) are being recommended for use as the primary patterns for the previous 2 use cases:

- Resolution: `http://uniresolver.io/did:xyz:1234`
- Dereferencing (general case): `http://uniresolver.io/did:xyz:1234#key1` and, optionally, `http://uniresolver.io/did:xyz:1234!$selectId="key1"`

### Approach

The general approach is:

 1. Use the original architectural principles from the draft `did-spec` as well as the higher-level DID user scenarios from several documents (see below) to create a comprehensive list of lower-level `did-uri` use cases for the `did-uri` grammar
 2. Use the lower-level `did-uri` use cases which in turn can drive the design of the `did-uri` grammar (expressed at a higher level using ABNF notation) 
 3. Use the `did-uri` grammar design to drive the implementation (i.e. ABNF source code) for the actual `did-uri` grammar
 4. Validate the `did-uri` grammar by testing using test cases based on the `did-uri` lower-level use cases.
 5. Iterate

### Guiding Principles

1. Follow the Core Principles expressed in the following documents:

   1.1. [The #OpenToInnovation Principle: Internet protocols and standards not only need to be open, but more importantly, open to innovation](https://hyperonomy.com/2019/03/12/internet-protocols-and-standards-not-only-need-to-be-open-but-more-importantly-open-to-innovation/)

   1.2. [Giving Grammars Written with ABNF Notation the Respect They Deserve](https://hyperonomy.com/2019/03/11/giving-grammars-written-with-abnf-notation-the-respect-they-deserve/)
2. Ensure that an app developer has the tools he/she needs to be able to effectively search, find, resolve, and dereference:
   - a single DID Document associated with a DID, or
   - a collection of DID Documents based on several criteria (defined in the use cases)
3. Ensure that an app developer has the tools he/she needs to be able to effectively search, find, resolve, dereference, and execute:
   - a service endpoint associated with a service-id in a single DID Document associated with a DID.
4. Ensure that the above operations and capabilities are expressed in a consistent `did-uri` syntax - eliminating the need for creating additional language and/or API constructs, where possible.
5. Ensure that the draft "DID ABNF" supports the above goals and doesn't unnecessarily restrict future innovation with respect to `did-uri` parsing (and DID Resolution, specifically but not exclusively) ...that is, that the "DID ABNF" doesn't restrict the syntax patterns needed for present and future  `did-uri` parsing (and DID Resolution, specifically but not exclusively) innovation. This is especially important because the current "DID ABNF" is completely defined in a different specification from the DID Resolution specification (i.e. the DID Specification).
6. Ensure that an app developer has the tools he/she has the basic operational capabilities available to test if a DID Resolver is alive and responsive, control the format of the DID Resolver response, etc.
7. The `did-uri` use cases (the lower-level `did-uri` use cases) will be guided/driven by the specific higher-level DID user scenaios documents listed below. See Princple 1.2 above.

### Higher-Level Use Case Documents

Higher-level use case documents that have been selected to guide/drive the lower-level `did-uri` use cases:

1. [Use Cases for Decentralized Identifiers](https://w3c-ccg.github.io/did-use-cases/)
2. [Universal DID Operations](https://github.com/WebOfTrustInfo/rwot8-barcelona/blob/master/topics-and-advance-readings/Universal-DID-Operations.md)
3. [Indy draft feature-discovery 1.0 HIPE](https://github.com/dhh1128/indy-hipe/blob/9c7722d208cfe0a336cb67a626cbbb192ae73f8c/text/feature-discovery/README.md)
4. [Indy draft attachments HIPE](https://github.com/hyperledger/indy-hipe/blob/bd48bae3712e659c34d88c6dea839ccf5a0f0701/text/attachments/README.md#hipe-00-attachments)

## Lower-level `did-uri` Use Cases

Checkout the spreadsheets in: https://github.com/mwherman2000/did-uri-spec/tree/master/src

## `did-uri-spec` Grammar

```json
; https://github.com/mwherman2000/did-uri-spec/tree/master/abnf/did-uri-spec-2019-03-28.abnf

; !syntax("abnf")
did                       = "did:" method ":" method-specific-idstring
method                    = 1*methodchar
methodchar                = %x61-7A / DIGIT
method-specific-idstring  = idstring *( ":" idstring )
idstring                  = 1*idchar
idchar                    = ALPHA / DIGIT / "." / "-"

did-uri                   = did [ transform ] [ path-abempty ] [ "?" query ] [ "#" fragment ]

transform                 = PIPE transformer *( "&" transformer )
transformer               = transformer-nameonly / transformer-namevalue
transformer-nameonly      = "$" transformer-name
transformer-namevalue     = "$" transformer-name "=" DOUBLEQUOTE transformer-value DOUBLEQUOTE
transformer-name          = ALPHA 1*transform-char
transformer-name          = *transform-char
transformer-char          = ALPHA / DIGIT / "." / "-"

ALPHA                     =  %x41-5A / %x61-7A   ; A-Z / a-z
DIGIT                     =  %x30-39             ; 0-9
PIPE                      =  %x21                ; !
DOUBLEQUOTE               =  %x22                ; "
```

## Impact on DID Document Grammar

1. ";" is no longer needed/used in a DID Document. From a syntactical perspective, all "anchors" / "selection IDs" are prefixed with a '#' only. The semantic meaning is determined by the referring `did-uri` transformer.

## `did-uri` Grammar Validation Tool (Web)

The following web app is being used to validate the `did-uri` grammar against the lower-level use cases:

- [The BNF Verification Service](http://arran.fi.muni.cz/bnfparser2/)

## Appendix A - `did-uri` Service Endpoint Transformer Use Cases

### H. DID URI Service Endpoint Transformation Use Cases (using "!" transformer (pipe) option and $serviceId transform option)

These following use cases use the "!" transformer (pipe) option and `$serviceId` transformer (pipe) option (aka `$serviceId` transformer). These tokens immediately follow is formally the text that matches be the `did` rule.  The semantics are: take the `did` text (up to the "!" pipe option) and pass it through a transformation represented by the transform options that follow the "!" transformer (pipe) option.

For example, if the transformer is `$serviceId="<service-id>"`, the effect would be to produce the resolved URL/URI for, in this case, the service endpoint corresponding `service-id`.  See the table below for more specific examples of the syntax.

Conceptually, the processing is:

`did-uri` | transform(tranformOptions) to produce a `transformed-uri`

Here's are 2 specific examples based on the [Windley examples](http://www.windley.com/archives/2019/02/decentralized_identifiers.shtml).  These examples also make clear the difference between the _transformer_ approach and the ';' approach.

The subject DID document can be found in the Windley article or [here](examples/windley-diddoc-example.json).

| Approach | Example |
| ---------- | -------------------------- |
| Windley | `did:sov:123456789abcdefghij;exam_svc` |
| Transformer| `did:sov:123456789abcdefghij!$serviceId="exam_svc"` |

Both of the above resolve (dereference) to the same URI/URL: `https://example.com/endpoint/8377464`.

| Approach | Example |
| ---------- | -------------------------- |
| Windley | `did:sov:123456789abcdefghij;exam_svc/foo/bar?a=1#flip` |
| Transformer | `did:sov:123456789abcdefghij!$serviceId="exam_svc"/foo/bar?a=1#flip` |

Both of the above resolve (dereference) to the same URI/URL: `https://example.com/endpoint/8377464/foo/bar?a=1#flip`.

NOTE: DID schemes and/or DID Resolvers can define additional transform options.  They are not limited by the syntax specification.

NOTE: The ";" token is no longer used anywhere in DID syntax patterns represented across all of the use case categories.

NOTE: Related (and reflecting the views of @dhh128 in comment https://github.com/w3c-ccg/did-spec/pull/168#issuecomment-471655338), there should no longer be a need to use ";' or any special symbol (other than "#") in the `id` attribute of a service endpoint in a DID Document. 

## Appendix B - DID Document Examples

1. [DID Spec - Example 16](examples/did-spec-example16.json)
2. [INDY-ARM Example](examples/INDY-ARM-example.json)
3. [Windley Article Example](examples/windley-diddoc-example.json)

## Appendix C - `did-uri` Grammar - Previous Versions

1. ["Before Barcelona (BB)" "DID ABNF"](abnf/did-abnf-2019-03-07.abnf) - using ";" for service point `service-id` dereferencing
2. ["After Barcelona (AB)" "DID ABNF"](abnf/did-abnf-2019-03-06.abnf) - using "$" for service point `service-id` dereferencing and introducing "!" for `content-id` dereferencing
3. `did-uri-spec` version of the `did-uri` grammar - work-in-progress

## Appendix D - Other References

1. WebDav
2. Microsoft PowerShell
3. ABNF Specification
4. URI Specification
5. Draft Decentralized Identifiers specification
6. Draft DID Resolution Specificiation
7. OASIS OData Open Data Services Specification
