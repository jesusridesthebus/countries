using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Countries.Models
{
  public class Country
  {
    public string IdCode {get; set;}
    public string Name {get; set;}
    public string Continent {get; set;}
    public string Region {get; set;}
    public int IndepYear {get; set;}
    public int Population {get; set;}
    public int LifeExpectancy {get; set;}
    public int GNP {get; set;}
    public string GovernmentForm {get; set;}
    public int Code2 {get; set;}


    public Country (string name, string id)
    {
      Name = name;
      IdCode = id;
    }

    public static List<Country> GetAll()
    {
      List<Country> allCountries = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        string countryId = rdr.GetString(0);
        string countryDescription = rdr.GetString(1);
        Country newCountry = new Country(countryDescription, countryId);
        allCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCountries;
    }
    public static Country Find(string id)
    {
      Country selectedCountry = new Country("place", "ANE");
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country WHERE code ='" + id + "' ;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read();
      // int countryId = rdr.GetInt32(0);
      // string countryDescription = rdr.GetString(1);
      // Country newCountry = new Country(countryDescription, countryId);
      // allCountries.Add(newCountry);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return selectedCountry;
    }

  }
}
