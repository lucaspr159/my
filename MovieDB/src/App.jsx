import { Link, Outlet } from 'react-router-dom'
import './App.css'

function App() {
  return (
    <div className="App">
      <nav id="navbar">
        <h2>
          <Link to = '/'>Movies Lib</Link>
        </h2>
        <Link to = '/movie/1'>Movie1</Link>
        <Link to = '/search'>pesquisar</Link>
      </nav>
      <Outlet/>
    </div>
  )
}

export default App
