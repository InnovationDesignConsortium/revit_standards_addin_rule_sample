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
      "Parameters": [],
      "When run": ["Save"]
    }
  ]
}
```

## Here is a Workset Rule
Elements from the categories:
- Furniture
- Entourage
Will be moved to the workset:
- Level 1 Stuff
When they have a Level value of:
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
        {"Name": "Level", "Value": "Level 1"},
        {"Name": "Auto Assign Workset", "Value": "1"}
      ]
    }
  ]
}
```

## Here's a second Workset Rule
Elements from the categories:
- Furniture
- Entourage
Will be moved to the workset:
- Level 2 Stuff
When they have a Level value of:
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

## Below is a Parameter Rule

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

## This is also a Parameter Rule...

- description here

```json
{
  "Parameter Rules": 
  [
    {
      "Rule Name": "In Place Family Quantity",
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
