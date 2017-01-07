namespace InsuranceApp
{
    using System;

    public abstract class Root
    {
        protected DateTime creationDate;
        protected DateTime validDate;
        public bool Valid
        {
            get
            {
                if (DateTime.Now > this.validDate || DateTime.Now < creationDate)
                    return false;
                else
                    return true;
            }
        }
        public bool IsValidAtDate(DateTime date)
        {
            {
                if (DateTime.Now > date || date < creationDate)
                    return false;
                else
                    return true;
            }
        }
    }
}
