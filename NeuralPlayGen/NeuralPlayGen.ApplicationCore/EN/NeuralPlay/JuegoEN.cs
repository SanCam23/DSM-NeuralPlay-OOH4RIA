
using System;
// Definición clase JuegoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class JuegoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo genero
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum genero;



/**
 *	Atributo perfilJuego
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego;



/**
 *	Atributo perfil_0
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil_0;



/**
 *	Atributo equipo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum Genero {
        get { return genero; } set { genero = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> PerfilJuego {
        get { return perfilJuego; } set { perfilJuego = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN Perfil_0 {
        get { return perfil_0; } set { perfil_0 = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> Equipo {
        get { return equipo; } set { equipo = value;  }
}





public JuegoEN()
{
        perfilJuego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN>();
        equipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN>();
}



public JuegoEN(int id, string nombre, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum genero, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil_0, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo
               )
{
        this.init (Id, nombre, genero, perfilJuego, perfil_0, equipo);
}


public JuegoEN(JuegoEN juego)
{
        this.init (juego.Id, juego.Nombre, juego.Genero, juego.PerfilJuego, juego.Perfil_0, juego.Equipo);
}

private void init (int id
                   , string nombre, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum genero, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil_0, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Genero = genero;

        this.PerfilJuego = perfilJuego;

        this.Perfil_0 = perfil_0;

        this.Equipo = equipo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        JuegoEN t = obj as JuegoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
