

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class ReaccionCEN
 *
 */
public partial class ReaccionCEN
{
private IReaccionRepository _IReaccionRepository;

public ReaccionCEN(IReaccionRepository _IReaccionRepository)
{
        this._IReaccionRepository = _IReaccionRepository;
}

public IReaccionRepository get_IReaccionRepository ()
{
        return this._IReaccionRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum p_tipo, Nullable<DateTime> p_fechaCreacion, int p_usuario)
{
        ReaccionEN reaccionEN = null;
        int oid;

        //Initialized ReaccionEN
        reaccionEN = new ReaccionEN ();
        reaccionEN.Tipo = p_tipo;

        reaccionEN.FechaCreacion = p_fechaCreacion;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                reaccionEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                reaccionEN.Usuario.Id = p_usuario;
        }



        oid = _IReaccionRepository.New_ (reaccionEN);
        return oid;
}

public void Modify (int p_Reaccion_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum p_tipo, Nullable<DateTime> p_fechaCreacion)
{
        ReaccionEN reaccionEN = null;

        //Initialized ReaccionEN
        reaccionEN = new ReaccionEN ();
        reaccionEN.Id = p_Reaccion_OID;
        reaccionEN.Tipo = p_tipo;
        reaccionEN.FechaCreacion = p_fechaCreacion;
        //Call to ReaccionRepository

        _IReaccionRepository.Modify (reaccionEN);
}

public void Destroy (int id
                     )
{
        _IReaccionRepository.Destroy (id);
}

public ReaccionEN ReadOID (int id
                           )
{
        ReaccionEN reaccionEN = null;

        reaccionEN = _IReaccionRepository.ReadOID (id);
        return reaccionEN;
}

public System.Collections.Generic.IList<ReaccionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReaccionEN> list = null;

        list = _IReaccionRepository.ReadAll (first, size);
        return list;
}
}
}
