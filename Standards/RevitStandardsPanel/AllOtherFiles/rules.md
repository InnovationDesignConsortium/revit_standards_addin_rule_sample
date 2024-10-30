# Sample Rule Documentation

## Workset Rule - Levels and Grids
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

## Workset Rule - Level 1 Stuff (Furniture and Entourage)
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

## Workset Rule - Level 1 Stuff (Walls)
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

## Workset Rule - Level 2 Stuff (Furniture and Entourage)
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

## Parameter Rule - Wall Comments List
- This first rule limits the _Comments_ parameter on all elements in the **Walls** category to values of either 1, 2, or 3

```json
{
  "Parameter Rules": 
  [
    {
      "Rule Name": "Comments Rule For All Other Files",
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
  ]
}
```

## Parameter Rule - In-Place Family Max
- This custom rule limits the number of in-place families allowed in the project

```json
{
  "Parameter Rules": 
  [
    {
      "Rule Name": "In Place Family Quantity",
      "Element Classes": ["Autodesk.Revit.DB.FamilyInstance"],
      "Custom Code": "InPlaceFamilyCheck",
      "User Message": "There are too many In-Place Families in the model."
    }
  ]
}
```

## Parameter Rule - Set Quadrant
- This custom rule sets the quadrant of parameter of any family according to where it is in plan.

```json
{
  "Parameter Rules":
  [
    {
      "Rule Name": "Set Quadrant",
      "Element Classes": ["Autodesk.Revit.DB.FamilyInstance"],
      "Custom Code": "SetQuadrant",
    }
  ]
}
```
