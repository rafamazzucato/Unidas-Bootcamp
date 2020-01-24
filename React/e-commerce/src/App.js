import React from 'react';
import './App.css';

import '../node_modules/font-awesome/css/font-awesome.min.css';
import '../node_modules/jquery/dist/jquery.min';
import '../node_modules/popper.js/dist/umd/popper.min';
import '../node_modules/bootstrap/dist/js/bootstrap.min';
import '../node_modules/bootstrap/dist/css/bootstrap.css';

class App extends React.Component {

  state = {vitrine : []}

  componentWillMount(){
    this.carregarVitrine();
  }

  carregarVitrine(){
    fetch('http://localhost:56014/api/vitrine')
    .then(response => response.json())
    .then(data => {
      this.setState({vitrine : data})
    })
    .catch(error => {
      console.log(error)
    })
  }

  render(){

    console.log(this.state)
    return (
      <div className="App">
        <header className="App-header">
            {this.state.vitrine && this.state.vitrine.length > 0 ?
              this.state.vitrine.map(vitrine => {
                return (<div style={{padding: 10}}>
                  <p>{vitrine.nome}</p>
                  <p>{vitrine.preco}</p>
                  <p>{vitrine.descricao}</p>
                  <p>{vitrine.quantidadeEstoque}</p>
                </div>)   
              })
            : 
            null}
        </header>
      </div>
    );
  } 
}

export default App;
