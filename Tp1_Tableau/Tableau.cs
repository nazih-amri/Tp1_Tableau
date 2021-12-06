using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Tableau
{
    class Tableau
    {
        // declaration des variables
        private int dim { get; set; } // la dimension du tableau
        public string type { get; set; } // le type du tableau
        private double[] arrD { get; set; } // tableau de type double
        private string[] arrS { get; set; } // tableau de type string
        private char[] arrC { get; set; }  // tableau de type char

        /// <summary>
        /// constructeur de la class Tavleau qui permet de declarer un tableau selon le type de ce tableau
        /// </summary>
        /// <param name="dimm">dimension du tableau</param>
        /// <param name="type">le type du tableau(double,string ou char)</param>
        public Tableau(int dimm,string type)
        {
            this.type = type;
            switch (type)
            {
                case "double": arrD = new double[dim = dimm];
                    break;
                case "string": arrS = new string[dim = dimm];
                    break;
                case "char": arrC = new char[dim = dimm];
                    break;                
            }
        }


        //         insert methods

        /// <summary>
        /// methode d'insertion d'un valeur dans un tableau de type double selon sa position
        /// </summary>
        /// <param name="val">la valeur qu'on va inserer</param>
        /// <param name="pos">la position de la valeur dans le tableau</param>
        /// <returns>le resultat de la methode</returns>
        public bool insertD(double val,int pos)
        {
            if (pos < 0 || pos > dim)
                return false;
            else
            {
                for(int i = 0; i < dim; i++)
                {
                    if (i == pos)
                    {
                        arrD[i] = val;
                    } 
                }
                return true;
            }

        }
        /// <summary>
        /// methode d'insertion d'un valeur dans un tableau de type String selon sa position
        /// </summary>
        /// <param name="val">la chaine qu'on va inserer</param>
        /// <param name="pos">la position de la valeur dans le tableau</param>
        /// <returns>le resultat de la methode</returns>
        public bool insertS(string val, int pos)
        {
            if (pos < 0 || pos > dim)
                return false;
            else
            {
                for (int i = 0; i < dim; i++)
                {
                    if (i == pos)
                    {
                        arrS[i] = val;
                    }
                }
                return true;
            }

        }
        /// <summary>
        /// methode d'insertion d'un valeur dans un tableau de type Char selon sa position
        /// </summary>
        /// <param name="val">le caractere qu'on va inserer</param>
        /// <param name="pos">la position de la valeur dans le tableau</param>
        /// <returns>le resultat de la methode</returns>
        public bool insertC(char val, int pos)
        {
            if (pos < 0 || pos > dim)
                return false;
            else
            {
                for (int i = 0; i < dim; i++)
                {
                    if (i == pos)
                    {
                        arrC[i] = val;
                    }
                }
                return true;
            }

        }
        /// <summary>
        /// methode pour supprimer un valeur dans le tableau de type double
        /// </summary>
        /// <param name="val">la valeur qu'on va supprimer</param>
        /// <returns>le resultat de la methode</returns>
        public bool deleteD(double val)
        {
            int v = 0;
            for(int i = 0; i < dim; i++)
            {
                if (arrD[i] == val)
                {
                    for(int j = i; j < dim - 1; j++)
                    {
                        arrD[j] = arrD[j + 1];
                        v++;
                    }
                    dim--;
                }
               
            }
            if (v == 0)
                return false;
            else
                return true; 
        }


        //        delete methods

        /// <summary>
        /// methode pour supprimer un valeur dans le tableau de type String
        /// </summary>
        /// <param name="val">la valeur qu'on va supprimer</param>
        /// <returns>le resultat de la methode</returns>
        public bool deleteS(string val)
        {
            int v = 0;
            for (int i = 0; i < dim; i++)
            {
                if (arrS[i] == val)
                {
                    for (int j = i; j < dim - 1; j++)
                    {
                        arrS[j] = arrS[j + 1];
                        v++;
                    }
                    dim--;
                }

            }
            if (v == 0)
                return false;
            else
                return true;
        }
        /// <summary>
        /// methode pour supprimer un valeur dans le tableau de type char
        /// </summary>
        /// <param name="val">la valeur qu'on va supprimer</param>
        /// <returns>le resultat de la methode</returns>
        public bool deleteC(char val)
        {
            int v = 0;
            for (int i = 0; i < dim; i++)
            {
                if (arrC[i] == val)
                {
                    for (int j = i; j < dim - 1; j++)
                    {
                        arrC[j] = arrC[j + 1];
                       
                        v++;
                    }
                    dim--;
                }

            }
            if (v == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// mehode pour supprimer une valeur selon sa position
        /// </summary>
        /// <param name="pos">la position de la valeur qu'on va supprimer</param>
        /// <returns>resultat de la methode</returns>
        public bool deletePosD(int pos)
        {
            int v = 0;
            for(int i = 0; i < dim; i++)
            {
                if (i == pos)
                {
                    for(int j = 0; j < dim - 1; j++)
                    {
                        arrD[j] = arrD[j + 1];
                        v++;
                    }
                    dim--;
                }
            }
            if (v == 0)
                return false;
            else
                return true;
        }
        /// <summary>
        /// mehode pour supprimer une valeur selon sa position
        /// </summary>
        /// <param name="pos">la position de la valeur qu'on va supprimer</param>
        /// <returns>resultat de la methode</returns>
        public bool deletePosS(int pos)
        {
            int v = 0;
            for (int i = 0; i < dim; i++)
            {
                if (i == pos)
                {
                    for (int j = 0; j < dim - 1; j++)
                    {
                        arrS[j] = arrS[j + 1];
                        v++;
                    }
                    dim--;
                }
            }
            if (v == 0)
                return false;
            else
                return true;
        }
        /// <summary>
        /// mehode pour supprimer une valeur selon sa position
        /// </summary>
        /// <param name="pos">la position de la valeur qu'on va supprimer</param>
        /// <returns>resultat de la methode</returns>
        public bool deletePosC(int pos)
        {
            int v = 0;
            for (int i = 0; i < dim; i++)
            {
                if (i == pos)
                {
                    for (int j = 0; j < dim - 1; j++)
                    {
                        arrC[j] = arrC[j + 1];
                        v++;
                    }
                    dim--;
                }
            }
            if (v == 0)
                return false;
            else
                return true;
        }

        //        search methods

        /// <summary>
        /// methode pour rechercher une valeur dans un tableau de type double
        /// </summary>
        /// <param name="val">la valeur qu'on va rechercher</param>
        /// <returns>resultat de la methode</returns>
        public bool searchD(double val)
        {
            for(int i = 0; i < dim; i++)
            {
                if (arrD[i] == val)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// methode pour rechercher une valeur dans un tableau de type string
        /// </summary>
        /// <param name="val">la valeur qu'on va rechercher</param>
        /// <returns>resultat de la methode</returns>
        public bool searchS(string val)
        {
            for (int i = 0; i < dim; i++)
            {
                if (arrS[i] == val)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// methode pour rechercher une valeur dans un tableau de type char
        /// </summary>
        /// <param name="val">la valeur qu'on va rechercher</param>
        /// <returns>resultat de la methode</returns>
        public bool searchC(char val)
        {
            for (int i = 0; i < dim; i++)
            {
                if (arrC[i] == val)
                    return true;
            }
            return false;
        }

        // tri method

        /// <summary>
        /// methode pour tri un tableau de type double dans l'order croissant
        /// </summary>
        public void triD()
        {
            double t;
            for(int i = 0; i < dim - 1; i++)
            {
                for(int j = i + 1; j < dim; j++)
                {
                    if (arrD[i] > arrD[j])
                    {
                        t = arrD[i];
                        arrD[i] = arrD[j];
                        arrD[j] = t;
                    }
                }
            }
        }

        //  symetrie methods

          /// <summary>
          /// methode pour diterminer si un tableau de type double est symetrie ou non
          /// </summary>
          /// <returns>le resultat de la methode(symetrie = true, pas symetrie = false)</returns>
        public bool symD()
        {
            for (int i = 0,j = dim - 1; i <= dim; i++, j--)
            {
                if (arrD[i] == arrD[j])
                    return true;
            }
            return false;
        }
        /// <summary>
        /// methode pour diterminer si un tableau de type string est symetrie ou non
        /// </summary>
        /// <returns>le resultat de la methode(symetrie = true, pas symetrie = false)</returns>
        public bool symS()
        {
            for (int i = 0, j = dim - 1; i <= dim; i++, j--)
            {
                if (arrS[i] == arrS[j])
                    return true;
            }
            return false;
        }
        /// <summary>
        /// methode pour diterminer si un tableau de type char est symetrie ou non
        /// </summary>
        /// <returns>le resultat de la methode(symetrie = true, pas symetrie = false)</returns>
        public bool symC()
        {
            for (int i = 0, j = dim - 1; i <= dim; i++, j--)
            {
                if (arrC[i] == arrC[j])
                    return true;
            }
            return false;
        }

        //                            inverse methods
        
        /// <summary>
        /// methode pour inverser un tableau de type double
        /// </summary>
        public void inverseD()
        {
            double t;
            for(int i = 0; i < (dim / 2); i++)
            {
                t = arrD[i];
                arrD[i] = arrD[dim - i - 1];
                arrD[dim - i - 1] = t;
            }
        }

        /// <summary>
        /// methode pour inverser un tableau de type string
        /// </summary>
        public void inverseS()
        {
            string t;
            for (int i = 0; i < (dim / 2); i++)
            {
                t = arrS[i];
                arrS[i] = arrS[dim - i - 1];
                arrS[dim - i - 1] = t;
            }
        }
        /// <summary>
        /// methode pour inverser un tableau de type char
        /// </summary>
        public void inverseC()
        {
            char t;
            for (int i = 0; i < (dim / 2); i++)
            {
                t = arrC[i];
                arrC[i] = arrC[dim - i - 1];
                arrC[dim - i - 1] = t;
            }
        }

        //            Concatenation methods

         /// <summary>
         /// methode pour concatener deux tables dans un seul tableau de type double
         /// </summary>
         /// <param name="arr1">le premier tableau</param>
         /// <param name="arr2">2eme tableau</param>
         /// <returns>un tableau contenant les valeur des deux tables</returns>
        public Tableau concatD(double[] arr1,double[] arr2)
        {
            this.dim = arr1.Length + arr2.Length;
            for(int i = 0; i < arr1.Length; i++)
            {
                arrD[i] = arr1[i];
            }
            for(int i = 0, j = arr1.Length; j <dim && i<arr2.Length; i++, j++)
            {
                arrD[j] = arr2[i];
            }
            return this;
        }
        /// <summary>
        /// methode pour concatener deux tables dans un seul tableau de type string
        /// </summary>
        /// <param name="arr1">le premier tableau</param>
        /// <param name="arr2">2eme tableau</param>
        /// <returns>un tableau contenant les valeur des deux tables</returns>
        public Tableau concatS(string[] arr1, string[] arr2)
        {
            this.dim = arr1.Length + arr2.Length;
            for (int i = 0; i < arr1.Length; i++)
            {
                arrS[i] = arr1[i];
            }
            for (int i = 0, j = arr1.Length; j < dim && i < arr2.Length; i++, j++)
            {
                arrS[j] = arr2[i];
            }
            return this;
        }
        /// <summary>
        /// methode pour concatener deux tables dans un seul tableau de type char
        /// </summary>
        /// <param name="arr1">le premier tableau</param>
        /// <param name="arr2">2eme tableau</param>
        /// <returns>un tableau contenant les valeur des deux tables</returns>
        public Tableau concatC(char[] arr1, char[] arr2)
        {
            this.dim = arr1.Length + arr2.Length;
            for (int i = 0; i < arr1.Length; i++)
            {
                arrC[i] = arr1[i];
            }
            for (int i = 0, j = arr1.Length; j < dim && i < arr2.Length; i++, j++)
            {
                arrC[j] = arr2[i];
            }
            return this;
        }








    }
}
