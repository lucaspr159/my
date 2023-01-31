import styles from './Home.module.css'
import savings from '../../img/divPoup.png'
import LinkButton from '../layout/LinkButton'

function Home(){
    return (
        <section className={styles.homeContainer}>
            <h1>Bem-vindo ao <span>Calc Cost</span></h1>
            <p>Faça o gerenciamento de orçamento de seus projetos</p>
            <LinkButton to='/newproject' text='Criar Projeto'/>
            <img src={savings} alt="Poupar" />
        </section>
    )
}
export default Home