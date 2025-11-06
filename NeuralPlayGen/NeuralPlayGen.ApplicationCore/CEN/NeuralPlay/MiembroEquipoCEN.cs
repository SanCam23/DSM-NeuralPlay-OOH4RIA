

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class MiembroEquipoCEN
 *
 */
public partial class MiembroEquipoCEN
{
private IMiembroEquipoRepository _IMiembroEquipoRepository;

public MiembroEquipoCEN(IMiembroEquipoRepository _IMiembroEquipoRepository)
{
        this._IMiembroEquipoRepository = _IMiembroEquipoRepository;
}

public IMiembroEquipoRepository get_IMiembroEquipoRepository ()
{
        return this._IMiembroEquipoRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum p_rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum p_estado, Nullable<DateTime> p_fechaAlta, int p_equipo, int p_usuario)
{
        MiembroEquipoEN miembroEquipoEN = null;
        int oid;

        //Initialized MiembroEquipoEN
        miembroEquipoEN = new MiembroEquipoEN ();
        miembroEquipoEN.Rol = p_rol;

        miembroEquipoEN.Estado = p_estado;

        miembroEquipoEN.FechaAlta = p_fechaAlta;


        if (p_equipo != -1) {
                // El argumento p_equipo -> Property equipo es oid = false
                // Lista de oids id
                miembroEquipoEN.Equipo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN ();
                miembroEquipoEN.Equipo.Id = p_equipo;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                miembroEquipoEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                miembroEquipoEN.Usuario.Id = p_usuario;
        }



        oid = _IMiembroEquipoRepository.New_ (miembroEquipoEN);
        return oid;
}

public void Modify (int p_MiembroEquipo_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolEquipoEnum p_rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum p_estado, Nullable<DateTime> p_fechaAlta)
{
        MiembroEquipoEN miembroEquipoEN = null;

        //Initialized MiembroEquipoEN
        miembroEquipoEN = new MiembroEquipoEN ();
        miembroEquipoEN.Id = p_MiembroEquipo_OID;
        miembroEquipoEN.Rol = p_rol;
        miembroEquipoEN.Estado = p_estado;
        miembroEquipoEN.FechaAlta = p_fechaAlta;
        //Call to MiembroEquipoRepository

        _IMiembroEquipoRepository.Modify (miembroEquipoEN);
}

public void Destroy (int id
                     )
{
        _IMiembroEquipoRepository.Destroy (id);
}

public MiembroEquipoEN ReadOID (int id
                                )
{
        MiembroEquipoEN miembroEquipoEN = null;

        miembroEquipoEN = _IMiembroEquipoRepository.ReadOID (id);
        return miembroEquipoEN;
}

public System.Collections.Generic.IList<MiembroEquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MiembroEquipoEN> list = null;

        list = _IMiembroEquipoRepository.ReadAll (first, size);
        return list;
}
}
}
