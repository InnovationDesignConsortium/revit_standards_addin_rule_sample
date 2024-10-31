# Sample Rule Documentation

This annotated Rules File is provided to both demonstrate how each rule type is configured _and_ to illustrate how a Rule File can be annotated. All [Github Flavored Markdown](https://github.github.com/gfm/) should be allowed, intersperced between closed JSON code blocks. Multiple code blocks for each of the two types of rules are allowed as long as they are identified as either a "Workset Rules" or a "Parameter Rules" block. Multiple rules are allowed within a block as well - there are some examples of this below.

Additional documentation can be found in the Readme of the [revit_standards_addin](https://github.com/InnovationDesignConsortium/revit_standards_addin) repository.

## Workset Rules

### Levels and Grids
This rule will enforce keeping Levels and Grids on the default Shared Levels and Grids workset. Notice that when no parameters are specified, all elements of the specified categories are captured by this rule.

```json
{
  "Workset Rules":
  [
    {
      "Categories": ["Levels", "Grids"],
      "Workset": "Shared Levels and Grids",
      "Parameters": []
    }
  ]
}
```

### Level 1 Stuff (Furniture and Entourage)
Elements from the _Revit Categories_:
- Furniture
- Entourage

Will be moved to the _Workset_:
- Level 1 Stuff

When they have a _Level_ value of:
- Level 1

```json
{
  "Workset Rules":
  [
    {
      "Categories": ["Furniture", "Entourage"],
      "Workset": "Level 1 Stuff",
      "Parameters":
      [
        {"Name": "Level", "Value": "Level 1"}
      ]
    }
  ]
}
```

### Level 1 Stuff (Walls)
Elements from the _Revit Category_:
- Walls

Will be moved to the _Workset_:
- Level 1 Stuff

When the elements meet multiple requirements. Note that Revit Walls do not have a _Level_ property, so for this rule, we must specify the _Base Constraint_ is:
- Level 1

And the _Function_ is:
- Interior

```json
{
  "Workset Rules":
  [
    {
      "Categories": ["Walls"],
      "Workset": "Level 1 Stuff",
      "Parameters":
      [
        {"Name": "Base Constraint", "Value": "Level 1"},
        {"Name": "Function", "Value": "Interior"}
      ]
    }
  ]
}
```

### Level 2 Stuff (Furniture and Entourage)
Elements from the _Revit Categories_:
- Furniture
- Entourage

Will be moved to the _Workset_:
- Level 2 Stuff

When they have a _Level_ value of:
- Level 2

```json
{
  "Workset Rules":
  [
    {
      "Categories": ["Furniture", "Entourage"],
      "Workset": "Level 2 Stuff",
      "Parameters":
      [
        {"Name": "Level", "Value": "Level 2"},
        {"Name": "Auto Assign Workset", "Value": "1"}
      ]
    }
  ]
}
```

## Parameter Rules

### List Rules
- The first list rule limits the _Comments_ parameter on all elements in the **Walls** category to values of either 1, 2, or 3. The values are enumerated in the rule.
- The second list rule ... The values are enumerated in an external CSV file.

```json
{
  "Parameter Rules": 
  [
    {
      "Rule Name": "Comments Rule For Walls",
      "Categories": ["Walls"],
      "Parameter Name": "Comments",
      "User Message": "Comments must be 1 2 or 3",
      "List Options":
      [
        {"name": "1", "description": ""},
        {"name": "2", "description": ""},
        {"name": "3", "description": ""}
      ]
    },
    {
      "Rule Name": "... something with a CSV file",
      "Categories": [],
      "Parameter Name": "",
      "Is Value Required": false,
      "User Message": "...",
      "List Source": "...csv"
    }
  ]
}
```

### Key Value Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Format Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Requirement Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Regex Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Formula Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### From Host Instance Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Prevent Duplicates Rule - (example)

Description

```json
{
  "Parameter Rules": 
  [
    {
    }
  ]
}
```

### Custom Code Rules
- The first custom code rule limits the number of in-place families allowed in the project. The limit and the logic are defined in the referenced CS file.
- The second custom code rule sets the value of a parameter on any family according to where it is in plan. The parameter and the logic are defined in the referenced CS file.

```json
{
  "Parameter Rules": 
  [
    {
      "Rule Name": "In Place Family Quantity Limit",
      "Element Classes": ["Autodesk.Revit.DB.FamilyInstance"],
      "Custom Code": "InPlaceFamilyCheck",
      "User Message": "There are too many In-Place Families in the model."
    },
    {
      "Rule Name": "Set Quadrant",
      "Element Classes": ["Autodesk.Revit.DB.FamilyInstance"],
      "Custom Code": "SetQuadrant",
    }
  ]
}
```
