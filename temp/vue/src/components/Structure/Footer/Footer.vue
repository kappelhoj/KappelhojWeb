<template>
  <div class="footer">
    <SocialLink 
      imageUrl="social-logos/linkedin-64.png" 
      topText="Linkedin"
      bottomText="Profile"
      path="https://www.linkedin.com/in/arvidlangsoe/"/>
    <SocialLink 
      imageUrl="social-logos/GitHub-Mark-Light-64px.png" 
      topText="Github"
      bottomText="Profile"
      path="https://github.com/kappelhoj"/>
  </div>
</template>


<script>
import SocialLink from './SocialLink'
export default{
  name: 'Footer',
  components: {
    SocialLink
  }
}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .footer{
    display: flex;
    margin: 0.0em 0.5em;
    text-align: left;
    justify-content: flex-start;
  }

</style>
