
using System.Collections.Generic;

public class Representative
{
    public string kind { get; set; }
    public Normalizedinput normalizedInput { get; set; }
    public Divisions divisions { get; set; }
    public List<Office> offices { get; set; }
    public List<Official> officials { get; set; }
}

public class Normalizedinput
{
    public string line1 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
}

public class Divisions
{
    public OcdDivisionCountryUs ocddivisioncountryus { get; set; }
    public OcdDivisionCountryUsState ocddivisioncountryusstate { get; set; }
    public OcdDivisionCountryUsStateCd ocddivisioncountryusstatecd { get; set; }
    public OcdDivisionCountryUsStateCounty ocddivisioncountryusstatecounty { get; set; }
    public OcdDivisionCountryUsStateCountyCouncil_District ocddivisioncountryusstatecountycouncil_district { get; set; }
    public OcdDivisionCountryUsStatePlace ocddivisioncountryusstateplace { get; set; }
    public OcdDivisionCountryUsStateSld ocddivisioncountryusstatesld { get; set; }
    public OcdDivisionCountryUsStateSldu ocddivisioncountryusstatesldu { get; set; }
}

public class OcdDivisionCountryUs
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class OcdDivisionCountryUsState
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class OcdDivisionCountryUsStateCd
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class OcdDivisionCountryUsStateCounty
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class OcdDivisionCountryUsStateCountyCouncil_District
{
    public string name { get; set; }
}

public class OcdDivisionCountryUsStatePlace
{
    public string name { get; set; }
}

public class OcdDivisionCountryUsStateSld
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class OcdDivisionCountryUsStateSldu
{
    public string name { get; set; }
    public List<int> officeIndices { get; set; }
}

public class Office
{
    public string name { get; set; }
    public string divisionId { get; set; }
    public List<string> levels { get; set; }
    public List<string> roles { get; set; }
    public List<int> officialIndices { get; set; }
}

public class Official
{
    public string name { get; set; }
    public List<Address> address { get; set; }
    public string party { get; set; }
    public List<string> phones { get; set; }
    public List<string> urls { get; set; }
    public string photoUrl { get; set; }
    public List<Channel> channels { get; set; }
    public List<string> emails { get; set; }
}

public class Address
{
    public string line1 { get; set; }
    public string line2 { get; set; }
    public string line3 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
}

public class Channel
{
    public string type { get; set; }
    public string id { get; set; }
}
