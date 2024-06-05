public class Address
{
    private string _number;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _additionalInfo;

    public Address(string number, string street, string city, string state, string zip, string additionalInfo="")
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        if (additionalInfo != "")
        {
            _additionalInfo = ", " + additionalInfo;
        }
    }

    public string GetAddressString()
    {
        return $"{_number} {_street}, {_city}, {_state}, {_zip}{_additionalInfo}";
    }
}