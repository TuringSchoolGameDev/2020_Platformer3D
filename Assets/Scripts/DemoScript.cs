using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class BETKOKSPAVADINIMAS : MonoBehaviour
//1. NegaliButiTarpu
//2. Negali prasideti skaicium
//3. Du skirptai negali vienodai vadintis
//4. IsDidziosiosRaides ir kiekvienas zodis is didziosios raides

//riestiniai sklaisutai:
//1 atidaro ir uzdaro skriptus { }
//2 atidaro ir uzdaro funkcijas { }
//visais kitais atvejais eilute uzsibaigia kabliataskiu

//paciame skirpte:
//1) Funkcijos
//2) Kintamieji
public class DemoScript : MonoBehaviour //pasako kad skritpas DemoScirpt tures visas UnityGalimybes
{
    // <- visos eilutes kurios prasideda dviem bruksnelaiis yra komentarai.

    //kintamuosius
    //kintamieji turi savo tipa/turi savo pavadinima/ ir savo reiksme
    //kai mes apibrezinejam kintamaji jam reikia nurodyti jo tipa
    //int - sveikas skaicius = 5, -5, 0, 1000000, etc.
    //skaiciaus reiksme yra pavadinimas
    public int skaiciausReiksme = 5;
    //float - skaicius su kableliu
    public float skaiciusSuKableliu = 5.3f;

    //beveik viskas gali tureti savo matomuma:
    //skriptai, funkcijos, kintamieji
    //public - matomas yra didziausias
    //private - matomumas yra maziausias

    //funkcijos
    //jos prasideda zodziu void
    //jos turi pavadinima
    //ir gali tureti arba netureti parametru
    //jose yra kazkoks veikimas
    void Begti()
	{
        //pasiruosia startui
        //bega
        //kazka padaro
        //ir galiausiai nubega
        Begti2V(skaiciusSuKableliu);//i  egti v2 mes paduodam reiksme kuri yra laikoma kinamajame su pavadinimu skaiciusSuKableliu
        //po to kai begti 2v buvo padaryta atlieka dar kazkokkius veiksmus
	}

    void Begti2V(float greitis)
	{
        //kazkas vyksta v2
	}

    void Start()
    {
        //sita funkcija issikvies tada kada mes paleidziam zaidima
    }

    void Update()
    {
        //sita funkcija issikvies kiekvienam kadre
        gameObject.transform.position = new Vector3(0, skaiciusSuKableliu, 0);
    }
}
