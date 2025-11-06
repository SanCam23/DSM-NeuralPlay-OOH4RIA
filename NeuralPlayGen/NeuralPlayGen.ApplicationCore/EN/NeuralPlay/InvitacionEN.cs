
using System;
// Definición clase InvitacionEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class InvitacionEN
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
 *	Atributo fechaEnvio
 */
private Nullable<DateTime> fechaEnvio;



/**
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo equipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo;



/**
 *	Atributo emisor
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN emisor;



/**
 *	Atributo receptor
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> receptor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaEnvio {
        get { return fechaEnvio; } set { fechaEnvio = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Emisor {
        get { return emisor; } set { emisor = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> Receptor {
        get { return receptor; } set { receptor = value;  }
}





public InvitacionEN()
{
        receptor = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN>();
}



public InvitacionEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, Nullable<DateTime> fechaEnvio, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN emisor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> receptor
                    )
{
        this.init (Id, tipo, estado, fechaEnvio, comunidad, equipo, emisor, receptor);
}


public InvitacionEN(InvitacionEN invitacion)
{
        this.init (invitacion.Id, invitacion.Tipo, invitacion.Estado, invitacion.FechaEnvio, invitacion.Comunidad, invitacion.Equipo, invitacion.Emisor, invitacion.Receptor);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoInvitacionEnum tipo, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, Nullable<DateTime> fechaEnvio, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN emisor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> receptor)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Estado = estado;

        this.FechaEnvio = fechaEnvio;

        this.Comunidad = comunidad;

        this.Equipo = equipo;

        this.Emisor = emisor;

        this.Receptor = receptor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InvitacionEN t = obj as InvitacionEN;
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
