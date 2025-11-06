
using System;
// Definición clase SesionEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class SesionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fechaInicio
 */
private Nullable<DateTime> fechaInicio;



/**
 *	Atributo fechaFin
 */
private Nullable<DateTime> fechaFin;



/**
 *	Atributo token
 */
private string token;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual Nullable<DateTime> FechaFin {
        get { return fechaFin; } set { fechaFin = value;  }
}



public virtual string Token {
        get { return token; } set { token = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public SesionEN()
{
}



public SesionEN(int id, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin, string token, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                )
{
        this.init (Id, fechaInicio, fechaFin, token, usuario);
}


public SesionEN(SesionEN sesion)
{
        this.init (sesion.Id, sesion.FechaInicio, sesion.FechaFin, sesion.Token, sesion.Usuario);
}

private void init (int id
                   , Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin, string token, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.FechaInicio = fechaInicio;

        this.FechaFin = fechaFin;

        this.Token = token;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SesionEN t = obj as SesionEN;
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
