namespace MT_Forms.LogicForForms
{
    internal class ChangeSize
    {
        internal void ChangeMainFormWidthForShowLog()
        {
            if(Core.FormsStorage.mainProgramForm.Width == 280)
                Core.FormsStorage.mainProgramForm.Width = 695;
            else if(Core.FormsStorage.mainProgramForm.Width == 695)
                Core.FormsStorage.mainProgramForm.Width = 280;
        }
    }
}
