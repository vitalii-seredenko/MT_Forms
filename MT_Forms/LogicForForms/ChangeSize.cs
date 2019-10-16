namespace MT_Forms.LogicForForms
{
    internal class ChangeSize
    {
        internal void ChangeForm1Width()
        {
            if(Core.FormsInitialization.form1.Width == 280)
                Core.FormsInitialization.form1.Width = 680;
            else if(Core.FormsInitialization.form1.Width == 680)
                Core.FormsInitialization.form1.Width = 280;
        }
    }
}
