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
		// Get the application and document from external command data.
                Application app = commandData.Application.Application;
                Document activeDoc = commandData.Application.ActiveUIDocument.Document;

                // Creates a Revit task dialog to communicate information to the user.
                TaskDialog mainDialog = new TaskDialog("Hello, Revit!");
                mainDialog.MainInstruction = "Hello, Revit!";
                mainDialog.MainContent = 
                        "This sample shows how to use a Revit task dialog to communicate with the user." 
                        + "The command links below open additional task dialogs with more information.";

                // Add commmandLink options to task dialog
                mainDialog.AddCommandLink(TaskDialogCommandLinkId.CommandLink1,
                         "View information about the Revit installation");
                mainDialog.AddCommandLink(TaskDialogCommandLinkId.CommandLink2, 
                                "View information about the active document");

                // Set common buttons and default button. If no CommonButton or CommandLink is added,
                // task dialog will show a Close button by default
                mainDialog.CommonButtons = TaskDialogCommonButtons.Close;
                mainDialog.DefaultButton = TaskDialogResult.Close;

                // Set footer text. Footer text is usually used to link to the help document.
                mainDialog.FooterText = 
                        ""                          + "Click here for the Revit API Developer Center";

                TaskDialogResult tResult = mainDialog.Show();

                // If the user clicks the first command link, a simple Task Dialog 
                // with only a Close button shows information about the Revit installation. 
                if (TaskDialogResult.CommandLink1 == tResult)
                {
                        TaskDialog dialog_CommandLink1 = new TaskDialog("Revit Build Information");
                        dialog_CommandLink1.MainInstruction = 
                                "Revit Version Name is: " + app.VersionName + "\n"
                         + "Revit Version Number is: " + app.VersionNumber + "\n" 
                                + "Revit Version Build is: " + app.VersionBuild;

                        dialog_CommandLink1.Show();

                }

                // If the user clicks the second command link, a simple Task Dialog 
                // created by static method shows information about the active document
                else if (TaskDialogResult.CommandLink2 == tResult)
                {
                        TaskDialog.Show("Active Document Information", 
                                "Active document: " + activeDoc.Title + "\n"
                         + "Active view name: " + activeDoc.ActiveView.Name);
                }

                return Autodesk.Revit.UI.Result.Succeeded;

		
		//TaskDialog.Show("Custom Rule", null);
		// return the ids of elements that failed the rule, or <null>
		//return null;
	}
}
