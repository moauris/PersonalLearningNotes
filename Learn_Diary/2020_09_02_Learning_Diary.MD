
[toc]

# Overview: Today's tasks and fulfillment

- [ ] Task 1: Find out how to make XSLT file for XML transformation
- [ ] Task 2: Find out how to apply the XSLT transformation
- [ ] Task 3

# Topic 1: How to make XSLT file for XML transformation

## Summary

The XSLT is XML standards for transformation. It can style the original XML file to look like something else.

The problem at hand, as question raised on Stackoverflow, is called XML <span style="border-radius:5px;background:gray;color:white;padding:0px 5px">Node Grouping</span>. and it is quite common.

There is a method for implementing <span style="border-radius:5px;background:gray;color:white;padding:0px 5px">Node Grouping</span> is called the <span style="border-radius:5px;background:gray;color:white;padding:0px 5px">Muenchian Method</span> taken after *Steve Muench*.

http://www.jenitennison.com/xslt/grouping/muenchian.html

## Problem

Original XML:

```xml
<records>
	<contact id="0001">
		<title>Mr</title>
		<forename>John</forename>
		<surname>Smith</surname>
	</contact>
	<contact id="0002">
		<title>Dr</title>
		<forename>Amy</forename>
		<surname>Jones</surname>
	</contact>
	...
</records>
```

This is a common exported from database xml, it's called a flat structure data.

Target XML:

```xml
Jones,<br />
	Amy (Dr)<br />
	Brian (Mr)<br />
Smith,<br />
	Fiona (Ms)<br />
	John (Mr)<br />
```

This is to group by forename.

## Solution

The <span style="border-radius:5px;background:gray;color:white;padding:0px 5px">Muenchian Method</span>  is special in the use of `key` property.

```xml
<xsl:key name="contacts-by-surname" match="contact" use="surname"
```

In it, the contact is the parent node, surname is child node.

To use the key, call the key with the syntax:

```
key('key-name', use-match)
```

To use the example, perform a test transformation on my own xml:

https://freeformatter.com/xsl-transformer.html

There is an error...and I cannot debug it.

There might be two problem, 1) the syntax is wrong, 2) the Access Database doesn't support Key feature.

## Extra

# Topic 2: How to apply the XSLT transformation

## Summary

## Problem

## Solution

## Extra

# Topic 3:

## Summary

## Problem

## Solution

## Extra