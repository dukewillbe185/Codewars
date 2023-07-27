/* Now that we have a Block let's move on to something slightly more complex: a Sphere.

Arguments for the constructor
radius -> integer
mass -> integer
Methods to be defined
GetRadius()       =>  radius of the Sphere
GetMass()         =>  mass of the Sphere
GetVolume()       =>  volume of the Sphere (a double rounded to 5 place after the decimal)
GetSurfaceArea()  =>  surface area of the Sphere (a double rounded to 5 place after the decimal)
GetDensity()      =>  density of the Sphere (a double rounded to 5 place after the decimal)
Example
Sphere ball = new Sphere(2,50)
ball.GetRadius() ->       2
ball.GetMass() ->         50
ball.GetVolume() ->       33.51032
ball.GetSurfaceArea() ->  50.26548
ball.GetDensity() ->      1.49208
Any feedback would be much appreciated */

using System;

public class Sphere
{
  public int Radius;
  public int Mass;
  
  public Sphere(int radius, int mass){
    this.Radius = radius;
    this.Mass = mass;
  }
  
  public int GetRadius(){
    return Radius;
  }
  
  public int GetMass(){
    return Mass;
  }
  
  public double GetVolume(){
    double volume = Math.Round(((4.0/3.0) * Math.PI * Math.Pow(Radius, 3)), 5);
    return volume;
  }

  public double GetSurfaceArea(){
    double surfaceArea = 4 * Math.PI * Math.Pow(Radius, 2);
    return Math.Round(surfaceArea, 5);
  }

  public double GetDensity(){
    double volume = GetVolume();
    double density = Math.Round((Mass / volume), 5);
    return density;
  }

