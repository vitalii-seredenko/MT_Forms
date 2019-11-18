namespace MT_Forms.LogicForForms
{
    internal class ChangeSize
    {
        internal void ChangeForm1WidthForShowLog()
        {
            if(Core.FormsInitialization.mainProgramForm.Width == 280)
                Core.FormsInitialization.mainProgramForm.Width = 695;
            else if(Core.FormsInitialization.mainProgramForm.Width == 695)
                Core.FormsInitialization.mainProgramForm.Width = 280;
        }
    }
}
