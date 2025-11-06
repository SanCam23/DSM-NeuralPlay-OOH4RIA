
using System;
// Definición clase ParticipacionTorneoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class ParticipacionTorneoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo estado
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum estado;



/**
 *	Atributo fechaAlta
 */
private Nullable<DateTime> fechaAlta;



/**
 *	Atributo torneo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo;



/**
 *	Atributo equipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaAlta {
        get { return fechaAlta; } set { fechaAlta = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN Torneo {
        get { return torneo; } set { torneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN Equipo {
        get { return equipo; } set { equipo = value;  }
}





public ParticipacionTorneoEN()
{
}



public ParticipacionTorneoEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo
                             )
{
        this.init (Id, estado, fechaAlta, torneo, equipo);
}


public ParticipacionTorneoEN(ParticipacionTorneoEN participacionTorneo)
{
        this.init (participacionTorneo.Id, participacionTorneo.Estado, participacionTorneo.FechaAlta, participacionTorneo.Torneo, participacionTorneo.Equipo);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo)
{
        this.Id = id;


        this.Estado = estado;

        this.FechaAlta = fechaAlta;

        this.Torneo = torneo;

        this.Equipo = equipo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ParticipacionTorneoEN t = obj as ParticipacionTorneoEN;
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
