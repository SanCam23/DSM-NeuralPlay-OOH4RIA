
using System;
// Definición clase VotoTorneoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class VotoTorneoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo valor
 */
private bool valor;



/**
 *	Atributo fechaVoto
 */
private Nullable<DateTime> fechaVoto;



/**
 *	Atributo propuestaTorneo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual bool Valor {
        get { return valor; } set { valor = value;  }
}



public virtual Nullable<DateTime> FechaVoto {
        get { return fechaVoto; } set { fechaVoto = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public VotoTorneoEN()
{
}



public VotoTorneoEN(int id, bool valor, Nullable<DateTime> fechaVoto, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                    )
{
        this.init (Id, valor, fechaVoto, propuestaTorneo, usuario);
}


public VotoTorneoEN(VotoTorneoEN votoTorneo)
{
        this.init (votoTorneo.Id, votoTorneo.Valor, votoTorneo.FechaVoto, votoTorneo.PropuestaTorneo, votoTorneo.Usuario);
}

private void init (int id
                   , bool valor, Nullable<DateTime> fechaVoto, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Valor = valor;

        this.FechaVoto = fechaVoto;

        this.PropuestaTorneo = propuestaTorneo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VotoTorneoEN t = obj as VotoTorneoEN;
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
