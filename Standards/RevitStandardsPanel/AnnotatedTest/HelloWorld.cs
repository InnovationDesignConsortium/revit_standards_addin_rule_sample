using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

// change the name of the class to match the name of the cs file
public class HelloWorld
{
	TaskDialog mainDialog = new TaskDialog.Show("Custom Rule");
	mainDialog.MainInstruction = "Hello World!";
	mainDialog.MainContent = "This sample shows how to use a Revit task dialog to communicate with the user.";
	// return the ids of elements that failed the rule, or <null>
	mainDialog.Show();
	return null;
}
