
using System;
// Definición clase ComunidadEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class ComunidadEN
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
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fechaCreacion
 */
private Nullable<DateTime> fechaCreacion;



/**
 *	Atributo equipo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo;



/**
 *	Atributo torneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> torneo;



/**
 *	Atributo invitacion
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN invitacion;



/**
 *	Atributo miembroComunidad
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion;



/**
 *	Atributo solicitudIngreso
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso;



/**
 *	Atributo propuestaTorneo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual Nullable<DateTime> FechaCreacion {
        get { return fechaCreacion; } set { fechaCreacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> Torneo {
        get { return torneo; } set { torneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN Invitacion {
        get { return invitacion; } set { invitacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> MiembroComunidad {
        get { return miembroComunidad; } set { miembroComunidad = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> SolicitudIngreso {
        get { return solicitudIngreso; } set { solicitudIngreso = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}





public ComunidadEN()
{
        equipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN>();
        torneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN>();
        miembroComunidad = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN>();
        publicacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN>();
        solicitudIngreso = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN>();
}



public ComunidadEN(int id, string nombre, string descripcion, Nullable<DateTime> fechaCreacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN invitacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo
                   )
{
        this.init (Id, nombre, descripcion, fechaCreacion, equipo, torneo, invitacion, miembroComunidad, publicacion, solicitudIngreso, propuestaTorneo);
}


public ComunidadEN(ComunidadEN comunidad)
{
        this.init (comunidad.Id, comunidad.Nombre, comunidad.Descripcion, comunidad.FechaCreacion, comunidad.Equipo, comunidad.Torneo, comunidad.Invitacion, comunidad.MiembroComunidad, comunidad.Publicacion, comunidad.SolicitudIngreso, comunidad.PropuestaTorneo);
}

private void init (int id
                   , string nombre, string descripcion, Nullable<DateTime> fechaCreacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN invitacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.FechaCreacion = fechaCreacion;

        this.Equipo = equipo;

        this.Torneo = torneo;

        this.Invitacion = invitacion;

        this.MiembroComunidad = miembroComunidad;

        this.Publicacion = publicacion;

        this.SolicitudIngreso = solicitudIngreso;

        this.PropuestaTorneo = propuestaTorneo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComunidadEN t = obj as ComunidadEN;
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
