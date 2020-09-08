
[toc]

# Overview: Today's tasks and fulfillment

- [x] Task 1 Learn What are SVG and how can we use them
- [x] Task 2 Dissect a SVG file from one of the badges on Github readme file.
- [ ] Task 3 

# Topic 1: Learn What are SVG and how can we use them

## Summary

The introduction on SVG can be found on https://www.w3.org/Graphics/SVG/.

It stood fore Scalable Vector Graphics, it renders vector graphics written in XML format.

A taste of SVG:

```xml
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="106" height="20" role="img" aria-label="downloads: 2.9M">
    <title>downloads: 2.9M</title>
    <linearGradient id="s" x2="0" y2="100%">
        <stop offset="0" stop-color="#bbb" stop-opacity=".1"/>
        <stop offset="1" stop-opacity=".1"/>
    </linearGradient>
    <clipPath id="r">
        <rect width="106" height="20" rx="3" fill="#fff"/>
    </clipPath>
    <g clip-path="url(#r)">
        <rect width="69" height="20" fill="#555"/>
        <rect x="69" width="37" height="20" fill="#4c1"/>
        <rect width="106" height="20" fill="url(#s)"/>
    </g>
    <g fill="#fff" text-anchor="middle" font-family="Verdana,Geneva,DejaVu Sans,sans-serif" text-rendering="geometricPrecision" font-size="110">
        <text aria-hidden="true" x="355" y="150" fill="#010101" fill-opacity=".3" transform="scale(.1)" textLength="590">downloads</text>
        <text x="355" y="140" transform="scale(.1)" fill="#fff" textLength="590">downloads</text>
        <text aria-hidden="true" x="865" y="150" fill="#010101" fill-opacity=".3" transform="scale(.1)" textLength="270">2.9M</text>
        <text x="865" y="140" transform="scale(.1)" fill="#fff" textLength="270">2.9M</text>
    </g>
</svg>
```

And it renders this:

![](./2020_09_08_assets/example_svg.svg)

## Extra

Things to get from the example:

The `<svg/>` tag, has the usual width and height property, role, which is set to `img`, and there is the `aria-label` property, don't get know what that is.

Then, under the outer wrapper, there are the elements that are contents to the `svg` tag.

- title
- `linearGradient`
- `clipPath`
- `g`
- another `g`

Title, ignore.

Linear Gradient, defines as reference id "s", x2 as 0, y2 as 100%. This gradient brush has 2 colors tops, stop one offsets at 0, with color `#f86000`

More detailed example found on:

https://www.w3.org/Graphics/SVG/IG/resources/svgprimer.html#overview



# Topic 2:

## Summary

## Problem

## Solution

## Extra

# Topic 3:

## Summary

## Problem

## Solution

## Extra