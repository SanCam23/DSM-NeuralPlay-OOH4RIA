

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class MiembroComunidadCEN
 *
 */
public partial class MiembroComunidadCEN
{
private IMiembroComunidadRepository _IMiembroComunidadRepository;

public MiembroComunidadCEN(IMiembroComunidadRepository _IMiembroComunidadRepository)
{
        this._IMiembroComunidadRepository = _IMiembroComunidadRepository;
}

public IMiembroComunidadRepository get_IMiembroComunidadRepository ()
{
        return this._IMiembroComunidadRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum p_rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum p_estado, Nullable<DateTime> p_fechaAlta, int p_comunidad, int p_usuario)
{
        MiembroComunidadEN miembroComunidadEN = null;
        int oid;

        //Initialized MiembroComunidadEN
        miembroComunidadEN = new MiembroComunidadEN ();
        miembroComunidadEN.Rol = p_rol;

        miembroComunidadEN.Estado = p_estado;

        miembroComunidadEN.FechaAlta = p_fechaAlta;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                miembroComunidadEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                miembroComunidadEN.Comunidad.Id = p_comunidad;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                miembroComunidadEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                miembroComunidadEN.Usuario.Id = p_usuario;
        }



        oid = _IMiembroComunidadRepository.New_ (miembroComunidadEN);
        return oid;
}

public void Modify (int p_MiembroComunidad_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum p_rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum p_estado, Nullable<DateTime> p_fechaAlta)
{
        MiembroComunidadEN miembroComunidadEN = null;

        //Initialized MiembroComunidadEN
        miembroComunidadEN = new MiembroComunidadEN ();
        miembroComunidadEN.Id = p_MiembroComunidad_OID;
        miembroComunidadEN.Rol = p_rol;
        miembroComunidadEN.Estado = p_estado;
        miembroComunidadEN.FechaAlta = p_fechaAlta;
        //Call to MiembroComunidadRepository

        _IMiembroComunidadRepository.Modify (miembroComunidadEN);
}

public void Destroy (int id
                     )
{
        _IMiembroComunidadRepository.Destroy (id);
}

public MiembroComunidadEN ReadOID (int id
                                   )
{
        MiembroComunidadEN miembroComunidadEN = null;

        miembroComunidadEN = _IMiembroComunidadRepository.ReadOID (id);
        return miembroComunidadEN;
}

public System.Collections.Generic.IList<MiembroComunidadEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MiembroComunidadEN> list = null;

        list = _IMiembroComunidadRepository.ReadAll (first, size);
        return list;
}
}
}
