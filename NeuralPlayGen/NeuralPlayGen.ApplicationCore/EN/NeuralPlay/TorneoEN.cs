
using System;
// Definición clase TorneoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class TorneoEN
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
 *	Atributo fechaInicio
 */
private Nullable<DateTime> fechaInicio;



/**
 *	Atributo reglas
 */
private string reglas;



/**
 *	Atributo estado
 */
private bool estado;



/**
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo propuestaTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo;



/**
 *	Atributo participacionTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual string Reglas {
        get { return reglas; } set { reglas = value;  }
}



public virtual bool Estado {
        get { return estado; } set { estado = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> ParticipacionTorneo {
        get { return participacionTorneo; } set { participacionTorneo = value;  }
}





public TorneoEN()
{
        propuestaTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN>();
        participacionTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN>();
}



public TorneoEN(int id, string nombre, Nullable<DateTime> fechaInicio, string reglas, bool estado, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo
                )
{
        this.init (Id, nombre, fechaInicio, reglas, estado, comunidad, propuestaTorneo, participacionTorneo);
}


public TorneoEN(TorneoEN torneo)
{
        this.init (torneo.Id, torneo.Nombre, torneo.FechaInicio, torneo.Reglas, torneo.Estado, torneo.Comunidad, torneo.PropuestaTorneo, torneo.ParticipacionTorneo);
}

private void init (int id
                   , string nombre, Nullable<DateTime> fechaInicio, string reglas, bool estado, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo)
{
        this.Id = id;


        this.Nombre = nombre;

        this.FechaInicio = fechaInicio;

        this.Reglas = reglas;

        this.Estado = estado;

        this.Comunidad = comunidad;

        this.PropuestaTorneo = propuestaTorneo;

        this.ParticipacionTorneo = participacionTorneo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TorneoEN t = obj as TorneoEN;
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
