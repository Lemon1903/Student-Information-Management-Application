using StudentManagementLibrary;

// object creation for each classes
StudentInformation studentInfo = new StudentInformation();
StudentInsert studentInsert = new StudentInsert();
StudentDelete studentDelete = new StudentDelete();
StudentSearch studentSearch = new StudentSearch();
StudentEdit studentEdit = new StudentEdit();

// loop to continue operation
while (true)
{
    Console.Clear();
    Options.ShowOptions();

    // if chosen option of the user is not valid
    if (!ValidateInput.IsValidInput(UserDataCapture.PickOption(), "option"))
    {
        DisplayMessages.InvalidMessage();
        continue;
    }

    Console.Clear();

    // prompt user to the option clicked
    switch (Options.ChosenOption)
    {
        case 1: // display student information
            StudentDisplayInformation.Display(studentInfo);
            break;

        case 2: // insert new student information
            Student student = studentInsert.CaptureData();
            studentInsert.InsertData(studentInfo, student);
            break;

        case 3: // delete student information
            studentDelete.DoMethod(studentInfo);
            break;

        case 4: // search student information
            studentSearch.DoMethod(studentInfo);
            break;

        case 5: // edit student information
            studentEdit.DoMethod(studentInfo);
            break;

        case 6: // exit application
            Environment.Exit(0);
            break;
    }
}

