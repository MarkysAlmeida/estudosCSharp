using System;

public class Square {
    public double Altura;
    public double Largura;
    /* Altura (a) , largura (l) 
     * Area = a * l
     * perimetro = 2 * (a+l)
     * Diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(l, 2));
     */
    public double Area() {
        return Largura * Altura;
    }

    public double Perimentro() {
        return 2 * (Largura * Altura);
    }

    public double Diagonal() {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }
}
