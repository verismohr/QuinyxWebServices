using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Customer
{
    private int idField;

    private string nameField;

    private string contactField;

    private string address1Field;

    private string address2Field;

    private string zipField;

    private string cityField;

    private string countryField;

    private string cellPhoneField;

    private string phoneNoField;

    private string emailField;

    private string dateCreatedField;

    private string localeField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public string contact
    {
        get { return contactField; }
        set { contactField = value; }
    }

    public string address1
    {
        get { return address1Field; }
        set { address1Field = value; }
    }

    public string address2
    {
        get { return address2Field; }
        set { address2Field = value; }
    }

    public string zip
    {
        get { return zipField; }
        set { zipField = value; }
    }

    public string city
    {
        get { return cityField; }
        set { cityField = value; }
    }

    public string country
    {
        get { return countryField; }
        set { countryField = value; }
    }

    public string cellPhone
    {
        get { return cellPhoneField; }
        set { cellPhoneField = value; }
    }

    public string phoneNo
    {
        get { return phoneNoField; }
        set { phoneNoField = value; }
    }

    public string email
    {
        get { return emailField; }
        set { emailField = value; }
    }

    public string dateCreated
    {
        get { return dateCreatedField; }
        set { dateCreatedField = value; }
    }

    public string locale
    {
        get { return localeField; }
        set { localeField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
