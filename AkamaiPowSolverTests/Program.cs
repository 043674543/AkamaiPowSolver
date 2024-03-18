// See https://aka.ms/new-console-template for more information


using SecCptSolver;

string sec = "42622B62FBCD6C5D51D65A3A0C5D839B";

long timestamp = 1710755488;
string nonce = "d2758bcff3b2a7b489c4";
int difficulty = 3500;

var solver = new Solver(sec, timestamp, nonce, difficulty);
var pow = solver.ComputePoW();
Console.WriteLine("PoW: " + string.Join(", ", pow));
