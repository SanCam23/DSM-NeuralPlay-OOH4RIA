
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IJuegoRepository
{
void setSessionCP (GenericSessionCP session);

JuegoEN ReadOIDDefault (int id
                        );

void ModifyDefault (JuegoEN juego);

System.Collections.Generic.IList<JuegoEN> ReadAllDefault (int first, int size);



int New_ (JuegoEN juego);

void Modify (JuegoEN juego);


void Destroy (int id
              );


JuegoEN ReadOID (int id
                 );


System.Collections.Generic.IList<JuegoEN> ReadAll (int first, int size);
}
}
