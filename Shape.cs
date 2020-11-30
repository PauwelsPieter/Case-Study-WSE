using System;

public class Shape 
{
    private string Name;
    private string ValueA;
    private string ValueB;
    private string Calculation;


    public Shape (string Name, string ValueA, string ValueB, string Calculation){
        this.Name = Name;
        this.ValueA = ValueA;
        this.ValueB = ValueB;
        this.Calculation = Calculation;
    }
    public string getName() {
        return Name;
    }
    public string getValueA() {
        return ValueA;
    }
    public string getValueB() {
        return ValueB;
    }
    public string getCalculation() {
        return Calculation;
    }

    public double calculateResult(double ShapeValueA, double ShapeValueB) {
        double result = 0;

        switch (getName()) {
            case "rechthoek":
                result = ShapeValueA * ShapeValueB;
                break;
            case "driehoek":
                result = (ShapeValueA * ShapeValueB) / 2;
                break;
            case "cirkel":
                result = ShapeValueA * ShapeValueA * Math.PI;
                break;
        }

        return result;
    }
}