namespace MT_Forms.LogicForForms
{
    internal class ChangeSize
    {
        internal void ChangeForm1Width()
        {
            if(Core.FormsInitialization.loginForm.Width == 280)
                Core.FormsInitialization.loginForm.Width = 700;
            else if(Core.FormsInitialization.loginForm.Width == 700)
                Core.FormsInitialization.loginForm.Width = 280;
        }
    }
}
