
using System;
// Definición clase SolicitudIngresoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class SolicitudIngresoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo tipo
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum tipo;



/**
 *	Atributo estado
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado;



/**
 *	Atributo fechaSolicitud
 */
private Nullable<DateTime> fechaSolicitud;



/**
 *	Atributo fechaResolucion
 */
private Nullable<DateTime> fechaResolucion;



/**
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo equipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaSolicitud {
        get { return fechaSolicitud; } set { fechaSolicitud = value;  }
}



public virtual Nullable<DateTime> FechaResolucion {
        get { return fechaResolucion; } set { fechaResolucion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public SolicitudIngresoEN()
{
}



public SolicitudIngresoEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, Nullable<DateTime> fechaSolicitud, Nullable<DateTime> fechaResolucion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                          )
{
        this.init (Id, tipo, estado, fechaSolicitud, fechaResolucion, comunidad, equipo, usuario);
}


public SolicitudIngresoEN(SolicitudIngresoEN solicitudIngreso)
{
        this.init (solicitudIngreso.Id, solicitudIngreso.Tipo, solicitudIngreso.Estado, solicitudIngreso.FechaSolicitud, solicitudIngreso.FechaResolucion, solicitudIngreso.Comunidad, solicitudIngreso.Equipo, solicitudIngreso.Usuario);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, Nullable<DateTime> fechaSolicitud, Nullable<DateTime> fechaResolucion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Estado = estado;

        this.FechaSolicitud = fechaSolicitud;

        this.FechaResolucion = fechaResolucion;

        this.Comunidad = comunidad;

        this.Equipo = equipo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SolicitudIngresoEN t = obj as SolicitudIngresoEN;
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
