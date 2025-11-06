
using System;
// Definición clase MiembroEquipoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class MiembroEquipoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum rol;



/**
 *	Atributo estado
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado;



/**
 *	Atributo fechaAlta
 */
private Nullable<DateTime> fechaAlta;



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



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum Rol {
        get { return rol; } set { rol = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaAlta {
        get { return fechaAlta; } set { fechaAlta = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public MiembroEquipoEN()
{
}



public MiembroEquipoEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                       )
{
        this.init (Id, rol, estado, fechaAlta, equipo, usuario);
}


public MiembroEquipoEN(MiembroEquipoEN miembroEquipo)
{
        this.init (miembroEquipo.Id, miembroEquipo.Rol, miembroEquipo.Estado, miembroEquipo.FechaAlta, miembroEquipo.Equipo, miembroEquipo.Usuario);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Rol = rol;

        this.Estado = estado;

        this.FechaAlta = fechaAlta;

        this.Equipo = equipo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MiembroEquipoEN t = obj as MiembroEquipoEN;
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
