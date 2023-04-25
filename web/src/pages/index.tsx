import Head from 'next/head'
import styles from '@/styles/Home.module.css'
import DefaultPageWrapper from '@/components/Layout/DefaultPageWrapper'

export default function Home() {
  return (
    <>
      <Head>
        <title>Kappelhøj Dev</title>
        <meta name="description" content="Kappelhøj website" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main className={`${styles.main}`}>
        <div>
          <h1>Welcome to Kappelhoj.com</h1>
          <DefaultPageWrapper/>
        </div>
      </main>
    </>
  )
}
