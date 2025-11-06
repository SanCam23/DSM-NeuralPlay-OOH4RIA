

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class JuegoCEN
 *
 */
public partial class JuegoCEN
{
private IJuegoRepository _IJuegoRepository;

public JuegoCEN(IJuegoRepository _IJuegoRepository)
{
        this._IJuegoRepository = _IJuegoRepository;
}

public IJuegoRepository get_IJuegoRepository ()
{
        return this._IJuegoRepository;
}

public int New_ (string p_nombre, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum p_genero)
{
        JuegoEN juegoEN = null;
        int oid;

        //Initialized JuegoEN
        juegoEN = new JuegoEN ();
        juegoEN.Nombre = p_nombre;

        juegoEN.Genero = p_genero;



        oid = _IJuegoRepository.New_ (juegoEN);
        return oid;
}

public void Modify (int p_Juego_OID, string p_nombre, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.GeneroJuegoEnum p_genero)
{
        JuegoEN juegoEN = null;

        //Initialized JuegoEN
        juegoEN = new JuegoEN ();
        juegoEN.Id = p_Juego_OID;
        juegoEN.Nombre = p_nombre;
        juegoEN.Genero = p_genero;
        //Call to JuegoRepository

        _IJuegoRepository.Modify (juegoEN);
}

public void Destroy (int id
                     )
{
        _IJuegoRepository.Destroy (id);
}

public JuegoEN ReadOID (int id
                        )
{
        JuegoEN juegoEN = null;

        juegoEN = _IJuegoRepository.ReadOID (id);
        return juegoEN;
}

public System.Collections.Generic.IList<JuegoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<JuegoEN> list = null;

        list = _IJuegoRepository.ReadAll (first, size);
        return list;
}
}
}
