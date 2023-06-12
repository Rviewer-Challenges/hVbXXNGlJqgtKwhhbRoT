I used a winforms app and a converter library to convert different kind of units. To achieve this I used a nested .Net interfaces and parents to be able
to calculate all of them as the same interface and avoiding too much code typing using parents and easy get|sets, calculating the result by relations 
to a master unit of each kind, specified in each conversor.
All the listBoxes are populated in the same way by a conversor.AvailableConversors list and zipping each conversion despite the order or name.
Also implemented a list of multiple conversors, instanced only if used and reused if needed and a UnitTest case to certify Converter.dll operations.
