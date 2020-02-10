using System;
using System.Collections.Generic;
using System.Text;
using Humanity_Automatization;
using IronXL;
using Humanity_Automatization.Page.Objects;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization
{
    public class ExcelUtility
    {
        private static WorkBook wb=null; 
        private static WorkSheet ws = null; //pocetna vrednost ws-a
        public static bool OpenFile(string path) //kod za otvaranje wb fajla
        {
            try
            {
                if (wb == null) //znaci da wb nije ucitan nikad
                {
                    wb = WorkBook.Load(path); //ako nije ucitan, ucitaj ga
                }
                else
                {
                    Console.WriteLine("Neki fajl je vec ucitan!"); //neki wb je vec ucitan
                }
                return true; //ako ne dodje do greske, ucitavanje uspesno
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString()); //ako dodje do greske, ispisuje da wb nije ucitan, wb=null,false
                wb = null;
                return false;
            }
        }
        public static bool CloseFile() //kod za zatvaranje fajla
        {
            try {
                if (wb != null) //ako je neki wb ucitan, zatvori ga i postavi wb na null
                {
                    wb.Close();
                    wb = null;
                }
                return true;
            }catch(Exception e) //hvatanje greske prilikom zatvaranje
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Doslo je do greske prilikom zatvaranja!");
                return false; //vratiti false ako dodje do greske
            }
        }
        public static bool LoadWorkSheet(int index) //ucitvanje ws
        {
            try //npr. hocemo da ucitamo sheet sa index-om 50, a ima ih manje od 50
            {
                if (wb != null) //da li je excel sheet uspesno ucitan, da li wb nije null (ako nije null znaci da je ucitan)
                {
                    ws = wb.WorkSheets[index];
                    return true; //ws uspesno ucitan
                }
                else //wb ne postoji, ne moze ni da ucita ws
                {
                    return false;
                }
            } 
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Nije ucitan WorkSheet!");
                ws = null; //posto nije ucitan ws, stavlja mu se vrednost na null
                return false;
            }
        }
        public static string GetDataAt(int row, int column) //vadjenje informacija iz sheet-a
        {
            if (ws == null) //ako ne postoji ucitan ws, daj error da nije ucitan
            {
                Console.WriteLine("WorkSheet nije ucitan!");
                return "ERROR"; //mora da se vrati vrednost jer nije void
            }
            if (row < ws.Rows.Count) //broj izabranog reda mora da bude manji od broja redova (jer se krece od 0)
            {
                RangeRow rangeRow = ws.Rows[row]; //dohvata se izabran red
                if (column < rangeRow.Columns.Count) //ako je broj izabranog reda okej, proverava se da li je kolona okej
                {
                    RangeColumn rangeColumn = rangeRow.Columns[column]; //dohvata se izabrana kolona, unutar reda gadjamo sve kolone, pa uzimamo odredjenu sa indexom column
                    if (rangeColumn != null) //ako celija u koloni nije null, znaci da postoji i vraca se tekstualna vrednost (stringvalue)
                    {
                        return rangeColumn.StringValue;
                    }
                    else
                    {
                        Console.WriteLine("Ne postoji celija!"); //vraca se error ako celija ne postoji, ako je null
                        return "ERROR";
                    }
                }
                else //ako ne postoji kolona, vraca se error
                {
                    Console.WriteLine("Ne postoji kolona!");
                    return "ERROR";
                }
            }
            else //ako ne postoji red, vraca se error
            {
                Console.WriteLine("Ne postoji red!");
                return "ERROR";
            }
        }

        //Upisuje u excel tabelu podatak
        public static bool SetData(int row,string data) //u kom redu upisuje
        {
            if (ws == null) //da li je ucitan ws
            {
                Console.WriteLine("Greska u postavljanju podataka");
                return false;
            }

            ws.SetCellValue(row, ws.Rows[row].Columns.Count, data); //ako je ws ucitan, dodajemo range koji red, koja kolona, data
            wb.SaveAs(Constants.Excel_Path);
            return true;
        }
        //Vraca broj redova za trenutno ucitan ws, treba nam informacija za broj redova
        public static int GetRowCount()
        {
            if (ws == null) //ako je ws null, nije ucitan
            {
                Console.WriteLine("WorkSheet not loaded!");
                return 0;
            }
            else //ako jeste, vraca broj redova
            {
                return ws.Rows.Count;
            }
        }
    }
}
