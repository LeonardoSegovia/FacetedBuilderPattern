using System;

namespace FacetedBuilderPattern
{

    public class Person
    {

        public string StreetAddress, Postcode, City;

        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return
                $" {nameof(StreetAddress)}: {StreetAddress}, " +
                $"{Environment.NewLine} {nameof(Postcode)}: {Postcode}," +
                $"{Environment.NewLine} {nameof(City)}: {City}, " +
                $"{Environment.NewLine} {nameof(CompanyName)}: {CompanyName}, " +
                $"{Environment.NewLine} {nameof(Position)}: {Position}, " +
                $"{Environment.NewLine} {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

    public class PersonBuilder
    {

        protected Person person = new Person();

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int annualIncome)
        {
            person.AnnualIncome = annualIncome;
            return this;
        }
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }

    }
}
