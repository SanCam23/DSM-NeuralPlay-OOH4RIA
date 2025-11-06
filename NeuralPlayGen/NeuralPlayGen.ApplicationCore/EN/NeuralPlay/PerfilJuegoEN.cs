
using System;
// Definición clase PerfilJuegoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class PerfilJuegoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fechaAccion
 */
private Nullable<DateTime> fechaAccion;



/**
 *	Atributo perfil
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil;



/**
 *	Atributo juego
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN juego;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> FechaAccion {
        get { return fechaAccion; } set { fechaAccion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN Perfil {
        get { return perfil; } set { perfil = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN Juego {
        get { return juego; } set { juego = value;  }
}





public PerfilJuegoEN()
{
}



public PerfilJuegoEN(int id, Nullable<DateTime> fechaAccion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN juego
                     )
{
        this.init (Id, fechaAccion, perfil, juego);
}


public PerfilJuegoEN(PerfilJuegoEN perfilJuego)
{
        this.init (perfilJuego.Id, perfilJuego.FechaAccion, perfilJuego.Perfil, perfilJuego.Juego);
}

private void init (int id
                   , Nullable<DateTime> fechaAccion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN juego)
{
        this.Id = id;


        this.FechaAccion = fechaAccion;

        this.Perfil = perfil;

        this.Juego = juego;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PerfilJuegoEN t = obj as PerfilJuegoEN;
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
