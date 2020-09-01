
[toc]

# Overview: Today's tasks and fulfillment

Still remember the first diary for learning. On retrospect, it is such an audacious. It has gotten three tasks, and I haven't even completed one of them!

That being said, I still learned a lot from the half learning of just one task. Without further ado, let's try today's tasks. I need to readjust the goal and scope, to make them smaller and digestible.

- [x] Break in to the Book David Flanagan, *JavaScript, the Definitive Guide*. While you know, W3School almost had everything one needed to get to know JS.
- [ ] Learn C# Object to Binary or XML file Serialization
- [x] Figure out how to make master - detail from XML in WPF
- [x] Develop a WPF app for generating in-line HTML span styles for inserting labels in Typora <span style="border-radius:8px;color:white;background:red">&nbsp;&nbsp;Aborted&nbsp;&nbsp;</span>
- [ ] Learn to customize Visual Studio Snippets.

# Topic 1: WPF App - HTML_Span_Generator

## Summary

A simple app for generating span mark up language snippets with different styles

## Problem

- [x] Can Typora support rounded style table cells in a span label?

Typora supports a wide range of CSS stylings.

- [x] Common style template? How to find better visualizations? Design websites?

There are too many.

## Solution

W3School - CSS Rounded Corners: https://www.w3schools.com/css/css3_borders.asp

The `border-radius` sets the corners rounded, unit is PX.

Let's try to <span style="border-radius:8px;color:white;background:blue;padding:0px 10px">Make the corner rounded</span>

```css
<span style="border-radius:8px;color:white;background:blue;padding:0px 10px">Make the corner rounded</span>
```

OMG.... CSS is so much fun!

Abort this app, there is absolutely no need for this app. Just remember the syntax and create and use your own CSS line in the span, it can do literally anything with it!

## Extra

There is no extra.

# Topic 2: David Flanagan, *JavaScript, the Definitive Guide*

## Summary

Node.js is something that enables JS scripting outside of web browser.

JavaScript also enables users to select HTML DOM, and handles input and output. The reason why there is such a lack of HTML DOM support in other languages such as C# is because there is no need: JS is simple to learn, simple to use and extremely efficient and powerful.

Went through chapter 1, downloaded Node.js and gave it a test drive.

## Problem

There are no problem so far.

## Solution

There are no solutions so far.

## Extra

Need to learn CSS..

# Topic 3: Figure out how to make master - detail from XML in WPF

## Summary

OMG this sucks, don't you just hate this feeling? Everything seemed to be straight forward and simple, you know it should be simple, but you just couldn't hack it.

Master - Detail is a mechanism that selects sub level control's item source based on the parent (or master) levels. 

## Problem

- [ ] <span style="border-radius:10px;background:red;color:white;padding:0px 10px">#1</span> The XAML compiler cannot resolve the relative URI path.
- [ ] <span style="border-radius:10px;background:red;color:white;padding:0px 10px">#2</span> How to use the XPATH syntax to query for UNIQUE values (otherwise it would mean to modify the database export structure)
- [ ] <span style="border-radius:10px;background:red;color:white;padding:0px 10px">#3</span> (if <span style="border-radius:10px;background:red;color:white;padding:0px 10px">#2</span> fails...) How to conveniently format a flat structured xml to a recursive tree structure

**Flat structure versus Tree structure**

A Flat structure is how a data is exported from a database as xml file look like: the elements are arranged as each individual entry:

```xml
<dataset>
	<datarow>
        <column1>1</column1>
        <column2>dog</column2>
        <column3>corgi</column3>
        <column4>Puppy</column4>
    </datarow>
    <datarow>
        <column1>2</column1>
        <column2>dog</column2>
        <column3>corgi</column3>
        <column4>Paipai</column4>
    </datarow>
    <datarow>
        <column1>3</column1>
        <column2>dog</column2>
        <column3>Samoyd</column3>
        <column4>Baby</column4>
    </datarow>
    ...
</dataset>
```

A Tree structure looks like this, for the similar data collection:

```xml
<dataset>
	<dogs>
        <breed name="corgi">
        	<dog name="puppy"/>
            <dog name="Paipai"/>
        </breed>
        <breed name="Samoyd">
        	<dog name="Gouer"/>
            <dog name="Niffler"/>
            <dog name="Baby"/>
        </breed>
        ...
    </dog>
</dataset>
```

The solution is to either program (or find inbuilt functionality, like some sort of xml data structure converter) from a database, or find a way to select values that are unique from the entries.

The tree structure supports master detail model the best.

## Solution

<span style="border-radius:10px;background:darkgreen;color:white;padding:0px 10px">Solution: #2</span> There is actually a way, but whether if it can be implemented remains to be seen:

https://stackoverflow.com/questions/2871707/how-to-select-distinct-values-from-xml-document-using-xpath

Use the XPATH 2.0 `distinct-values()` function returns nodes with distinct values.

## Extra

# Topic 4: Why can't I add folders in Visual Studio?!

<span style="background:gray;color:white;padding:0px 20px">This is a non task listed topic.</span>

There are two views in Visual Studio's solution viewer. One is project view, the other is folder view.

In the project view, each folder represent a different namespace. They might look like they are `namespace.something` but visual studio would process them as different namespaces automatically.

Therefore, adding a new folder in project view meaning "adding a new namespace". 

# Topic 5: Devour Master-Details XML

Understand how this is actually done.