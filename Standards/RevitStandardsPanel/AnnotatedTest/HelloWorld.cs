using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

// change the name of the class to match the name of the cs file
public class HelloWorld
{
	// doc = active document
	// ids = the added or changed elements, or <null> if running the rule on the entire document
	public IEnumerable<ElementId> Run(Document doc, List<ElementId> ids)
	{
		// Creates a Revit task dialog to communicate information to the user.
		TaskDialog mainDialog = new TaskDialog("Custom Rule");
		mainDialog.MainInstruction = "Hello, World!";
		mainDialog.MainContent =
		    "This sample shows how a Revit task dialog can be added to a custom rule."
			+ "This rule is configured to run when a file is opened.";
		
		// Set common buttons and default button. If no CommonButton or CommandLink is added,
		// task dialog will show a Close button by default
		mainDialog.CommonButtons = TaskDialogCommonButtons.Close;
		mainDialog.DefaultButton = TaskDialogResult.Close;
		
		// Set footer text. Footer text is usually used to link to the help document.
		mainDialog.FooterText =
		    "<a href=\"http://usa.autodesk.com/adsk/servlet/index?siteID=123112&id=2484975 \">"
		    + "Click here for the Revit API Developer Center</a>";
		
		TaskDialogResult tResult = mainDialog.Show();
		
		// return the ids of elements that failed the rule, or <null>
		return null;
	}
}
