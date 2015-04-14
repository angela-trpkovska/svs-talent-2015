using System;
[AttributeUsage(AttributeTargets.Class)]
public class AccountMetadataAttribute:System.Attribute
{ 
    private string accountDescription;
    private string accountLimitations;

    public string AccountDescription
    {
        get { return this.accountDescription; } 
        set { this.accountDescription = value; }
     }

    public string AccountLimitations
    {
        get { return this.accountLimitations; }
        set { this.accountLimitations = value; }
    }

   

}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class FormatRestrictionAttribute : System.Attribute
{ 
   private string formatString;
   private int maxLength;

   public string FormatString
   {
       get { return formatString; }
       set { formatString = value; }
   }

    public int MaxLength
   {
       get { return maxLength; }
       set { maxLength = value; }
   }

}


