# did-url-spec - Decentralized Identifier URL (`did-url`) Specification

_Draft document for discussion purposes_

- Michael Herman (Toronto/Calgary/Seattle)
- Hyperonomy Business Blockchain Project / Parallelspace Corporation
- March 2019

Update cycle: As required - sometimes several times in a single day.

## Purpose, Goals, and Drivers

### Purpose

TODO

### GOals

TODO

### Drivers

In the Feb. 21, 2019 DID Resolution community call, there was a early/initial discussion about using an HTTP binding pattern such as:

>http://uniresolver.io/resolve/did:xyz:1234
>http://uniresolver.io/dereference/did:xyz:1234#key1

I was surprised to see the above pattern being proposed because the resolve and dereference operations are redundant ...but that's why we have these conversations (and write things down).

I assume that the purpose of the current "DID ABNF" syntax discussions is to encapsulate these types of operations into what we are currently calling a did-url (link). Based on these assumptions, I expected that the following did-url patterns (and corresponding HTTP bindings) will be used as the primary patterns for the previous 2 use cases:

- Resolution: http://uniresolver.io/did:xyz:1234 (Reference: w3c-ccg/did-spec#170 (comment))
- Dereferencing (general case): http://uniresolver.io/did:xyz:1234#key1 (Reference: w3c-ccg/did-spec#170 (comment))

## Guiding Principles

1. Follow the Core Principles expressed in the following documents:
   1.1. [The #OpenToInnovation Principle: Internet protocols and standards not only need to be open, but more importantly, open to innovation](https://hyperonomy.com/2019/03/12/internet-protocols-and-standards-not-only-need-to-be-open-but-more-importantly-open-to-innovation/)

   1.2. [Giving Grammars Written with ABNF Notation the Respect They Deserve](https://hyperonomy.com/2019/03/11/giving-grammars-written-with-abnf-notation-the-respect-they-deserve/)
2. Ensure that an app developer has the tools he/she needs to be able to effectively search, find, resolve, and dereference:
   - a single DID Document associated with a DID, or
   - a collection of DID Documents based on several criteria (defined in the use cases)
3. Ensure that an app developer has the tools he/she needs to be able to effectively search, find, resolve, dereference, and execute:
   - a service endpoint associated with a service-id in a single DID Document associated with a DID.
4. Ensure that the above operations and capabilities are expressed in a consistent did-url syntax - eliminating the need for creating additional language and/or API constructs, where possible.
5. Ensure that the draft "DID ABNF" supports the above goals and doesn't unnecessarily restrict future innovation with respect to `did-url` parsing (and DID Resolution, specifically but not exclusively) ...that is, that the "DID ABNF" doesn't restrict the syntax patterns needed for present and future  `did-url` parsing (and DID Resolution, specifically but not exclusively) innovation. This is especially important because the current "DID ABNF" is completely defined in a different specification from the DID Resolution specification (i.e. the DID Specification).
6. Ensure that an app developer has the tools he/she has the basic operational capabilities available to test if a DID Resolver is alive and responsive, control the format of the DID Resolver response, etc.
7. The `did-url` use cases (the lower-level `did-url` use cases) will be guided/driven by the specific higher-level use case documents listed below. See Princple 1.2 above.

### Higher-Level Use Case Documents

Higher-level use case documents that have been selected to guide/drive the lower-level `did-url` use cases:
1. [Use Cases for Decentralized Identifiers](https://w3c-ccg.github.io/did-use-cases/)
2. [Universal DID Operations](https://github.com/WebOfTrustInfo/rwot8-barcelona/blob/master/topics-and-advance-readings/Universal-DID-Operations.md)
3. [Indy feature-discovery 1.0 HIPE](https://github.com/dhh1128/indy-hipe/blob/9c7722d208cfe0a336cb67a626cbbb192ae73f8c/text/feature-discovery/README.md)

## Lower-level `did-url` Use Cases

Checkout the spreadsheets in: https://github.com/mwherman2000/did-url-spec/tree/master/src

## `did-url` Grammar - Previous Versions

1. ["Before Barcelona (BB) "DID ABNF"](abnf/did-abnf-2019-03-07.abnf) - using ";" for service point `service-id` dereferencing
2. ["After Barcelona (AB) "DID "ABNF"](abnf/did-abnf-2019-03-06.abnf) - using "$" for service point `service-id` dereferencing and introducing "!" for `content-id` dereferencing

## DID Doocument Examples

1. [DID Spec - Example 16](examples\did-spec-example16.json)
2. [INDY-ARM Example](examples\INDY-ARM-example.json)

## Other References

1. WebDav
2. Microsoft PowerShell
3. ABNF Specification
4. URI Specification
