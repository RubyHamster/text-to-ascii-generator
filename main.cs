using System;
namespace asciiGen
{
    class Program
    {
        public static String[] A = new string[6] { @"  ___  ", @" / _ \ ", @"/ /_\ \", @"|  _  |", @"| | | |", @"\_| |_/"};
        public static String[] B = new string[6] { @"______ ", @"| ___ \", @"| |_/ /", @"| ___ \", @"| |_/ /", @"\____/ "};
        public static String[] C = new string[6] { @" _____ ", @"/  __ \", @"| /  \/", @"| |    ", @"| \__/\", @" \____/" };
        public static String[] D = new string[6] { @"______ ", @"|  _  \", @"| | | |", @"| | | |", @"| |/ / ", @"|___/  " };
        public static String[] E = new string[6] { @" _____ ", @"|  ___|", @"| |__  ", @"|  __| ", @"| |___ ", @"\____/ " };
        public static String[] F = new string[6] { @"______ ", @"|  ___|", @"| |_   ", @"|  _|  ", @"| |    ", @"\_|    " };
        public static String[] G = new string[6] { @" _____ ", @"|  __ \", @"| |  \/", @"| | __ ", @"| |_\ \", @" \____/" };
        public static String[] H = new string[6] { @" _   _ ", @"| | | |", @"| |_| |", @"|  _  |", @"| | | |", @"\_| |_/" };
        public static String[] I = new string[6] { @" _____ ", @"|_   _|", @"  | |  ", @"  | |  ", @" _| |_ ", @" \___/ " };
        public static String[] J = new string[6] { @"   ___ ", @"  |_  |", @"    | |", @"    | |", @"/\__/ /", @"\____/ " };
        public static String[] K = new string[6] { @" _   __", @"| | / /", @"| |/ / ", @"|    \ ", @"| |\  \", @"\_| \_/" };
        public static String[] L = new string[6] { @" _     ", @"| |    ", @"| |    ", @"| |    ", @"| |____", @"\_____/" };
        public static String[] M = new string[6] { @"___  ___", @"|  \/  |", @"| .  . |", @"| |\/| |", @"| |  | |", @"\_|  |_/" };
        public static String[] N = new string[6] { @" _   _ ", @"| \ | |", @"|  \| |", @"| . ` |", @"| |\  |", @"\_| \_/" };
        public static String[] O = new string[6] { @" _____ ", @"|  _  |", @"| | | |", @"| | | |", @"\ \_/ /", @" \___/ " };
        public static String[] P = new string[6] { @"______ ", @"| ___ \", @"| |_/ /", @"|  __/ ", @"| |    ", @"\_|    " };
        public static String[] Q = new string[6] { @" _____ ", @"|  _  |", @"| | | |", @"| | | |", @"\ \/' /", @" \_/\_\" };
        public static String[] R = new string[6] { @"______ ", @"| ___ \", @"|    / ", @"| |_/ /", @"| |\ \ ", @"\_| \_|"};
        public static String[] S = new string[6] { @" _____ ", @"/  ___|", @"\ `--. ", @" `--. \", @"/\__/ /", @"\____/ " };
        public static String[] T = new string[6] { @" _____ ", @"|_   _|", @"  | |  ", @"  | |  ", @"  | |  ", @"  \_/  " };
        public static String[] U = new string[6] { @" _   _ ", @"| | | |", @"| | | |", @"| | | |", @"| |_| |", @" \___/ " };
        public static String[] V = new string[6] { @" _   _ ", @"| | | |", @"| | | |", @"| | | |", @"\ \_/ /", @" \___/ " };
        public static String[] W = new string[6] { @" _    _ ", @"| |  | |", @"| |  | |", @"| |/\| |", @"\  /\  /", @" \/  \/ " };
        public static String[] X = new string[6] { @"__   __", @"\ \ / /", @" \ V / ", @" /   \ ", @"/ /^\ \", @"\/   \/" };
        public static String[] Y = new string[6] { @"__   __", @"\ \ / /", @" \ V / ", @"  \ /  ", @"  | |  ", @"  \_/  " };
        public static String[] Z = new string[6] { @" ______", @"|___  /", @"   / / ", @"  / /  ", @"./ /___", @"\_____/" };
        static void asciiGen(string input)
        {
            string space1 = "";
            string space2 = "";
            string space3 = "";
            string space4 = "";
            string space5 = "";
            string space6 = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a")
                {
                    space1 += A[1];
                    space2 += A[2];
                    space3 += A[3];
                    space4 += A[4];
                    space5 += A[5];
                    space6 += A[0];
                }
                if (input[i].ToString() == "b")
                {
                    space1 += B[1];
                    space2 += B[2];
                    space3 += B[3];
                    space4 += B[4];
                    space5 += B[5];
                    space6 += B[0];
                }
                if (input[i].ToString() == "c")
                {
                    space1 += C[1];
                    space2 += C[2];
                    space3 += C[3];
                    space4 += C[4];
                    space5 += C[5];
                    space6 += C[0];
                }
                if (input[i].ToString() == "d")
                {
                    space1 += D[1];
                    space2 += D[2];
                    space3 += D[3];
                    space4 += D[4];
                    space5 += D[5];
                    space6 += D[0];
                }
                if (input[i].ToString() == "e")
                {
                    space1 += E[1];
                    space2 += E[2];
                    space3 += E[3];
                    space4 += E[4];
                    space5 += E[5];
                    space6 += E[0];
                }
                if (input[i].ToString() == "f")
                {
                    space1 += F[1];
                    space2 += F[2];
                    space3 += F[3];
                    space4 += F[4];
                    space5 += F[5];
                    space6 += F[0];
                }
                if (input[i].ToString() == "g")
                {
                    space1 += G[1];
                    space2 += G[2];
                    space3 += G[3];
                    space4 += G[4];
                    space5 += G[5];
                    space6 += G[0];
                }
                if (input[i].ToString() == "h")
                {
                    space1 += H[1];
                    space2 += H[2];
                    space3 += H[3];
                    space4 += H[4];
                    space5 += H[5];
                    space6 += H[0];
                }
                if (input[i].ToString() == "i")
                {
                    space1 += I[1];
                    space2 += I[2];
                    space3 += I[3];
                    space4 += I[4];
                    space5 += I[5];
                    space6 += I[0];
                }
                if (input[i].ToString() == "j")
                {
                    space1 += J[1];
                    space2 += J[2];
                    space3 += J[3];
                    space4 += J[4];
                    space5 += J[5];
                    space6 += J[0];
                }
                if (input[i].ToString() == "k")
                {
                    space1 += K[1];
                    space2 += K[2];
                    space3 += K[3];
                    space4 += K[4];
                    space5 += K[5];
                    space6 += K[0];
                }
                if (input[i].ToString() == "l")
                {
                    space1 += L[1];
                    space2 += L[2];
                    space3 += L[3];
                    space4 += L[4];
                    space5 += L[5];
                    space6 += L[0];
                }
                if (input[i].ToString() == "m")
                {
                    space1 += M[1];
                    space2 += M[2];
                    space3 += M[3];
                    space4 += M[4];
                    space5 += M[5];
                    space6 += M[0];
                }
                if (input[i].ToString() == "n")
                {
                    space1 += N[1];
                    space2 += N[2];
                    space3 += N[3];
                    space4 += N[4];
                    space5 += N[5];
                    space6 += N[0];
                }
                if (input[i].ToString() == "o")
                {
                    space1 += O[1];
                    space2 += O[2];
                    space3 += O[3];
                    space4 += O[4];
                    space5 += O[5];
                    space6 += O[0];
                }
                if (input[i].ToString() == "p")
                {
                    space1 += P[1];
                    space2 += P[2];
                    space3 += P[3];
                    space4 += P[4];
                    space5 += P[5];
                    space6 += P[0];
                }
                if (input[i].ToString() == "q")
                {
                    space1 += Q[1];
                    space2 += Q[2];
                    space3 += Q[3];
                    space4 += Q[4];
                    space5 += Q[5];
                    space6 += Q[0];
                }
                if (input[i].ToString() == "r")
                {
                    space1 += R[1];
                    space2 += R[2];
                    space3 += R[3];
                    space4 += R[4];
                    space5 += R[5];
                    space6 += R[0];
                }
                    if (input[i].ToString() == "s")
                    {
                        space1 += S[1];
                        space2 += S[2];
                        space3 += S[3];
                        space4 += S[4];
                        space5 += S[5];
                        space6 += S[0];
                    }
                    if (input[i].ToString() == "t")
                    {
                        space1 += T[1];
                        space2 += T[2];
                        space3 += T[3];
                        space4 += T[4];
                        space5 += T[5];
                        space6 += T[0];
                    }
                    if (input[i].ToString() == "u")
                    {
                        space1 += U[1];
                        space2 += U[2];
                        space3 += U[3];
                        space4 += U[4];
                        space5 += U[5];
                        space6 += U[0];
                    }
                    if (input[i].ToString() == "v")
                    {
                        space1 += V[1];
                        space2 += V[2];
                        space3 += V[3];
                        space4 += V[4];
                        space5 += V[5];
                        space6 += V[0];
                    }
                    if (input[i].ToString() == "w")
                    {
                        space1 += W[1];
                        space2 += W[2];
                        space3 += W[3];
                        space4 += W[4];
                        space5 += W[5];
                        space6 += W[0];
                    }
                    if (input[i].ToString() == "x")
                    {
                        space1 += X[1];
                        space2 += X[2];
                        space3 += X[3];
                        space4 += X[4];
                        space5 += X[5];
                        space6 += X[0];
                    }
                    if (input[i].ToString() == "y")
                    {
                        space1 += Y[1];
                        space2 += Y[2];
                        space3 += Y[3];
                        space4 += Y[4];
                        space5 += Y[5];
                        space6 += Y[0];
                    }
                    if (input[i].ToString() == "z")
                    {
                        space1 += Z[1];
                        space2 += Z[2];
                        space3 += Z[3];
                        space4 += Z[4];
                        space5 += Z[5];
                        space6 += Z[0];
                    }
                if (input[i].ToString() == " ")
                {
                    space1 += "  ";
                    space2 += "  ";
                    space3 += "  ";
                    space4 += "  ";
                    space5 += "  ";
                    space6 += "  ";
                }
            }
                Console.WriteLine(space6);
                Console.WriteLine(space1);
                Console.WriteLine(space2);
                Console.WriteLine(space3);
                Console.WriteLine(space4);
                Console.WriteLine(space5);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                asciiGen(Console.ReadLine().ToLowerInvariant());
            }
        }
    }
}
